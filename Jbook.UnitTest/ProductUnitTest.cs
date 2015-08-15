using System;
using System.Threading;
using Jbook.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jbook.UnitTest {
    [TestClass]
    public class ProductUnitTest {
        [TestMethod]
        public void TestMethod1() {
            ProductController productController = new ProductController();

            var result = productController.Get(1);

            var responseText = result.ExecuteAsync(new CancellationToken(false)).Result.StatusCode.ToString();

            Console.WriteLine(responseText);
        }
    }
}