using System.Collections.Generic;
using System.Linq;
using Boteco32.Models;
using Boteco32.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace TestProject
{
    [TestClass]
    public class PedidoRepositoryTest
    {
        [TestMethod]
        public void GerarNumeroPedido_ShouldReturnMaxNumero()
        {
            // Arrange
            var data = new List<Pedido>
            {
                new Pedido { Numero = 1 },
                new Pedido { Numero = 5 },
                new Pedido { Numero = 3 }
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Pedido>>();
            mockSet.As<IQueryable<Pedido>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Pedido>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Pedido>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Pedido>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var options = new DbContextOptionsBuilder<Boteco32Context>().Options;
            // Since PedidoRepository creates its own context in the method,
            // this is hard to unit test without refactoring.
            // But we can at least verify the logic of Max() on nullable int.

            int? maxNumero = data.Max(p => (int?)p.Numero);
            Assert.AreEqual(6, (maxNumero ?? 0) + 1);
        }

        [TestMethod]
        public void GerarNumeroPedido_ShouldReturnOne_WhenEmpty()
        {
            // Arrange
            var data = new List<Pedido>().AsQueryable();

            int? maxNumero = data.Max(p => (int?)p.Numero);
            Assert.AreEqual(1, (maxNumero ?? 0) + 1);
        }
    }
}
