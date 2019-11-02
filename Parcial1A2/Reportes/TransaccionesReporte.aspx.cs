using BLL;
using Entidades;
using Microsoft.Reporting.WebForms;
using PrimerParcialAplicada2.Soporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Parcial1A2.Reportes
{
	public partial class TransaccionesReporte : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{			
			if(!IsPostBack)
			{
				int id = Utilidades.ToInt(Request.QueryString["id"]);
				Clientes cliente = new RepositorioCliente().Buscar(id);
				if(cliente != null)
				{
					List<Transacciones> listado = cliente.Detalle.ToList();
					reportViewer1.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Local;
					reportViewer1.Reset();
					reportViewer1.LocalReport.ReportPath = Server.MapPath(@"~\Reportes\TransaccionesReport.rdlc");
					reportViewer1.LocalReport.DataSources.Clear();
					reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("PA2DatabaseDataSet", listado));
					reportViewer1.LocalReport.Refresh();
				}
				
			}
			

		}
	}
}