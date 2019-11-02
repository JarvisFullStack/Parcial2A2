using BLL;
using Entidades;
using PrimerParcialAplicada2.Soporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Parcial1A2.Consultas
{
	public partial class cTransacciones : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}
		

		protected void VerReporteButton_Click(object sender, EventArgs e)
		{
			int id = Utilidades.ToInt(FiltroTextBox.Text);
			if(id > 0)
			{
				Response.Redirect($"~/Reportes/TransaccionesReporte.aspx?id={id}");
			}
		}

		protected void BuscarButton_Click(object sender, EventArgs e)
		{
			int id = Utilidades.ToInt(FiltroTextBox.Text);
			if(id > 0)
			{
				Clientes cliente = new RepositorioCliente().Buscar(id);
				DatosGridView.DataSource = null;
				DatosGridView.DataBind();
				DatosGridView.DataSource = cliente.Detalle;
				DatosGridView.DataBind();
			}
		}
	}
}