using MASGlobalBusinessLayer.Entities;
using MASGlobalBusinessLayer.Exceptions;
using MASGlobalDataLayer.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MASGlobalBusinessLayer
{
    public class MASGlobalEmployeesManager
    {
        private MASGlobalClient dataClient { get; set; }

        public MASGlobalEmployeesManager( string employeesApiEndpoint )
        {
            dataClient = new MASGlobalClient(employeesApiEndpoint);
        }

        public List<EmployeeDTO> GetEmployees()
        {
            List<EmployeeDTO> employeeList = new List<EmployeeDTO>();

            var employees = dataClient.GetEmployees();
            if( employees != null )
            {
                foreach( var employee in employees )
                {
                    employeeList.Add(EmployeeFactory.GetEmployeeBySalaryType(employee));
                }
            }

            return employeeList;
        }

        public EmployeeDTO GetEmployeeById( int pId )
        {
            var employee = dataClient.GetEmployeeById(pId);

            if( employee != null )
            {
                return EmployeeFactory.GetEmployeeBySalaryType(employee);
            }
            else
            {
                throw new EmployeeNotFoundException("Employee not found");
            }
        }
    }
}
