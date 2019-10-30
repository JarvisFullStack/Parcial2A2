using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;

namespace BLL
{
	public class RepositorioCliente : RepositorioBase<Clientes>
	{
		public override bool Modificar(Clientes entity)
		{
			bool paso = false;
			Clientes Anterior = Buscar(entity.ClienteId);
			Contexto context = new Contexto();
			try
			{
				using (Contexto contexto = new Contexto())
				{
					foreach (var item in Anterior.Detalle.ToList())
					{
						if (!entity.Detalle.Exists(x => x.Id_Transaccion == item.Id_Transaccion))
						{
							contexto.Entry(item).State = EntityState.Deleted;
						}
					}
					contexto.SaveChanges();
				}
				foreach (var item in entity.Detalle.ToList())
				{
					EntityState state = EntityState.Unchanged;
					if (item.Id_Transaccion == 0)
					{
						state = EntityState.Added;
						context.Entry(item).State = state;
					}
				}
				context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
				paso = context.SaveChanges() > 0;
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				context.Dispose();
			}
			return paso;
		}


		public override Clientes Buscar(int id)
		{
			Clientes Clientes = new Clientes();
			Contexto contexto = new Contexto();
			try
			{
				Clientes = contexto.Clientes.Include(x => x.Detalle).Where(x => x.ClienteId == id).FirstOrDefault();
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				contexto.Dispose();
			}
			return Clientes;
		}

		
	}
}
