using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MASGlobalBusinessLayer.Entities
{
    public class EmployeeMonthlySalaryDTO : EmployeeDTO
    {
        public double annualSalary { get => salary * 12; }

        public EmployeeMonthlySalaryDTO(int pId, string pName, string pContractTypeName, int pRoleId, string pRoleName, string pRoleDescription, double pMonthlySalary )
            : base(pId, pName, pContractTypeName, pRoleId, pRoleName, pRoleDescription, pMonthlySalary)
        {
        }
    }
}
