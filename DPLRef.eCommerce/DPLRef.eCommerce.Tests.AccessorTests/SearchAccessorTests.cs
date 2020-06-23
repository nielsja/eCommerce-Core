using DPLRef.eCommerce.Accessors;
using DPLRef.eCommerce.Accessors.Catalog;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DPLRef.eCommerce.Tests.AccessorTests
{
    [TestClass]
    class SearchAccessorTests
    {
        [TestMethod]
        public void SearchAccessor_Test()
        {
            // arrange
            var accessor = new AccessorFactory(null, null).CreateAccessor<ISearchAccessor>();

            // act
            accessor.RebuildIndex(1);
            var results = accessor.Search(1, "Toyta"); // Toyota

            // assert
            Assert.AreEqual(10, results.Length);
        }
    }
}
