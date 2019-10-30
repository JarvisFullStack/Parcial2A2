using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class Transacciones
	{
		[Key]
		public int Id_Transaccion { get; set; }
		public string Tipo { get; set; }
		public decimal Monto { get; set; }
		public DateTime Fecha { get; set; }

		public Transacciones(int id_Transaccion, string tipo, decimal monto, DateTime fecha)
		{
			Id_Transaccion = id_Transaccion;
			Tipo = tipo;
			Monto = monto;
			Fecha = fecha;
		}

		public Transacciones()
		{
			this.Fecha = DateTime.Now;
		}
	}
}
