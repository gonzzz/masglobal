using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MASGlobalBusinessLayer.Entities
{
    public abstract class EmployeeDTO
    {
        public int id { get; set; }

        public string name { get; set; }

        public string contractTypeName { get; set; }

        public int roleId { get; set; }

        public string roleName { get; set; }

        public string roleDescription { get; set; }

        public double salary { get; set; }        

        public EmployeeDTO( int pId, string pName, string pContractTypeName, int pRoleId, string pRoleName, string pRoleDescription, double pSalary )
        {
            id = pId;
            name = pName;
            contractTypeName = pContractTypeName;
            roleId = pRoleId;
            roleName = pRoleName;
            roleDescription = pRoleDescription;
            salary = pSalary;
        }
    }
}
