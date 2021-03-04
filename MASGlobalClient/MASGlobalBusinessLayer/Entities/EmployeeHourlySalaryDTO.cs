using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MASGlobalBusinessLayer.Entities
{
    public class EmployeeHourlySalaryDTO : EmployeeDTO
    {
        public double annualSalary { get => 120 * salary * 12; }

        public EmployeeHourlySalaryDTO(int pId, string pName, string pContractTypeName, int pRoleId, string pRoleName, string pRoleDescription, double pHourlySalary)
            : base(pId, pName, pContractTypeName, pRoleId, pRoleName, pRoleDescription, pHourlySalary)
        {
        }
    }
}
