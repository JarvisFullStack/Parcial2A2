using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class Clientes
	{
		[Key]
		public int ClienteId { get; set; }
		public string Nombres { get; set; }
		public decimal Balance {			
			get {
				decimal balance = 0;
				foreach (var item in this.Detalle)
				{
					balance += item.Monto;
				}
				return balance;
			}
		}		

		public virtual List<Transacciones> Detalle { get; set; }

		public Clientes()
		{
			this.Detalle = new List<Transacciones>();
		}

		public Clientes(int clienteId, string nombres)
		{
			ClienteId = clienteId;
			Nombres = nombres;				
		}
	}
}
