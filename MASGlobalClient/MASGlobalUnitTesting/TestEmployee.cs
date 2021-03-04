using System;
using MASGlobalBusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MASGlobalUnitTesting
{
    [TestClass]
    public class TestEmployee
    {
        private const string apiEndpointTest = "http://masglobaltestapi.azurewebsites.net/api/Employees";

        /// <summary>
        /// Tests the MASGlobal Employees api. Must return one or more employees.
        /// </summary>
        [TestMethod]
        public void TestGetEmployees()
        {
            MASGlobalEmployeesManager mng = new MASGlobalEmployeesManager(apiEndpointTest);

            var employees = mng.GetEmployees();

            Assert.IsNotNull(employees);
            Assert.IsTrue(employees.Count > 0);
        }

        /// <summary>
        /// Tests the MASGlobal Employees api. Must return employee with id = 1
        /// </summary>
        [TestMethod]
        public void TestGetEmployeeById()
        {
            MASGlobalEmployeesManager mng = new MASGlobalEmployeesManager(apiEndpointTest);

            var employee = mng.GetEmployeeById(1);

            Assert.IsNotNull(employee);
            Assert.IsTrue(employee.id == 1);
        }
    }
}
