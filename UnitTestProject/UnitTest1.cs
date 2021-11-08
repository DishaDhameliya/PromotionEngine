using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine;
using System;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        //Scenario A
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                List<Product> lstProduct = new List<Product>();
                lstProduct.Add(new Product("A"));
                lstProduct.Add(new Product("B"));
                lstProduct.Add(new Product("C"));
                Assert.AreEqual(Product.returnTotalPrice(lstProduct), 100);
            }
            catch (Exception e)
            {

                throw;
            }
        }

        //Scenario B
        [TestMethod]
        public void TestMethod2()
        {
            List<Product> lstProduct = new List<Product>();
            lstProduct.Add(new Product("A"));
            lstProduct.Add(new Product("A"));
            lstProduct.Add(new Product("A"));
            lstProduct.Add(new Product("A"));
            lstProduct.Add(new Product("A"));
            lstProduct.Add(new Product("B"));
            lstProduct.Add(new Product("B"));
            lstProduct.Add(new Product("B"));
            lstProduct.Add(new Product("B"));
            lstProduct.Add(new Product("B"));
            lstProduct.Add(new Product("C"));
            Assert.AreEqual(Product.returnTotalPrice(lstProduct), 370);
           
        }

        //Scenario C
        [TestMethod]
        public void TestMethod3()
        {
            List<Product> lstProduct = new List<Product>();
            lstProduct.Add(new Product("A"));
            lstProduct.Add(new Product("A"));
            lstProduct.Add(new Product("A"));
            lstProduct.Add(new Product("B"));
            lstProduct.Add(new Product("B"));
            lstProduct.Add(new Product("B"));
            lstProduct.Add(new Product("B"));
            lstProduct.Add(new Product("B"));
            lstProduct.Add(new Product("C"));
            lstProduct.Add(new Product("D"));
            Assert.AreEqual(Product.returnTotalPrice(lstProduct), 280);
        }
    }
}
