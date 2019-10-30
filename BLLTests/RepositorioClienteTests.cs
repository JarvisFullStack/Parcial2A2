using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace BLL.Tests
{
	[TestClass()]
	public class RepositorioClienteTests
	{
		[TestMethod()]
		public void ModificarTest()
		{
			Assert.IsTrue(true);
		}

		[TestMethod()]
		public void BuscarTest()
		{
			Assert.IsTrue(true);
		}

		[TestMethod()]
		public void GuardarCliente()
		{
			Clientes cliente1 = new Clientes(0, "Luis");
			Clientes cliente2 = new Clientes(0, "Felipe");
			RepositorioCliente repositorio = new RepositorioCliente();
			bool paso1 = repositorio.Guardar(cliente1);
			bool paso2 = repositorio.Guardar(cliente2);

			Assert.IsTrue(paso1 && paso2);
		}

		/// <summary>
		/// Deberia buscar un cliente con id 1 en la base de datos diferente de nulo
		/// </summary>
		[TestMethod()]
		public void BuscarCliente()
		{
			Clientes cliente = new RepositorioCliente().Buscar(1);
			Assert.IsTrue(cliente != null);
		}


		/// <summary>
		/// Deberia obtener una lista de clientes cuya cantidad sea mayor que cero.
		/// </summary>
		[TestMethod()]
		public void GetList()
		{
			List<Clientes> lista = new RepositorioCliente().GetList(x => true);
			Assert.IsTrue(lista.Count() > 0);
		}


		/// <summary>
		/// Deberia buscar un cliente con id 1 y modificarlo.
		/// </summary>
		[TestMethod()]
		public void ModificarCliente()
		{
			RepositorioCliente repositorio = new RepositorioCliente();
			Clientes cliente = repositorio.Buscar(1);
			cliente.Nombres = "LUISSS";
			bool paso = repositorio.Modificar(cliente);
			Assert.IsTrue(paso);
		}

		/// <summary>
		/// Deberia eliminar el cliente con el id 2
		/// </summary>
		[TestMethod()]
		public void EliminarCliente()
		{
			bool paso = new RepositorioCliente().Eliminar(2);
			Assert.IsTrue(paso);
		}

		/// <summary>
		/// Deberia agregar dos transacciones al cliente con id 1 cada una con un monto de 100,
		/// posteriormente modificar ese cliente.
		/// </summary>
		[TestMethod()]
		public void AgregarDetalle()
		{
			RepositorioCliente repositorio = new RepositorioCliente();
			Clientes cliente = repositorio.Buscar(1);
			cliente.Detalle.Add(new Transacciones(0, "Tipo1", 100, DateTime.Now));
			cliente.Detalle.Add(new Transacciones(0, "Tipo2", 100, DateTime.Now));
			bool paso = repositorio.Modificar(cliente);
			Assert.IsTrue(paso);
		}

		/// <summary>
		/// Deberia obtener el cliente con id 1 y que la cantidad de transacciones sea 
		/// mayor que 0 y el balance igual a 200.
		/// </summary>
		[TestMethod()]
		public void GetListDetalle()
		{
			RepositorioCliente repositorio = new RepositorioCliente();
			Clientes cliente = repositorio.Buscar(1);
			Assert.IsTrue(cliente.Detalle.Count() > 0 && cliente.Balance == 200);
		}

		/// <summary>
		/// Deberia buscar el cliente con el id 1, eliminar una transaccion
		/// y posteriormente 
		/// </summary>
		[TestMethod()]
		public void ModificarDetalle()
		{
			RepositorioCliente repositorio = new RepositorioCliente();
			Clientes cliente = repositorio.Buscar(1);
			cliente.Detalle.RemoveAt(1);
			repositorio.Modificar(cliente);
			Clientes clienteModificado = repositorio.Buscar(1);
			Assert.IsTrue(clienteModificado.Detalle.Count() == 1 && clienteModificado.Balance == 100);
		}

	}
}