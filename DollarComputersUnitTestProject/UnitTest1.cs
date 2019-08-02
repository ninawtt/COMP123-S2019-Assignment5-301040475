using System;
using COMP123_S2019_Assignment5_301040475.Views;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DollarComputersUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestThatSelectFormHasLoadedDataSource()
        {
            // arange
            SelectForm selectForm;

            // act
            selectForm = new SelectForm();

            // assert
            Assert.IsTrue(selectForm.HasLoadedDataSource());
        }
    }
}
