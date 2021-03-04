using MASGlobalBusinessLayer.Exceptions;
using MASGlobalDataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MASGlobalBusinessLayer.Entities
{
    public class EmployeeFactory
    {
        public static EmployeeDTO GetEmployeeBySalaryType( EmployeePOCO pEmployee )
        {

            if( pEmployee != null )
            {
                if( pEmployee.contractTypeName == "HourlySalaryEmployee" )
                {
                    return new EmployeeHourlySalaryDTO(pEmployee.id, pEmployee.name, pEmployee.contractTypeName, 
                        pEmployee.roleId, pEmployee.roleName, pEmployee.roleDescription, pEmployee.hourlySalary);
                }
                else if( pEmployee.contractTypeName == "MonthlySalaryEmployee" )
                {
                    return new EmployeeMonthlySalaryDTO(pEmployee.id, pEmployee.name, pEmployee.contractTypeName,
                        pEmployee.roleId, pEmployee.roleName, pEmployee.roleDescription, pEmployee.monthlySalary);
                }
                else
                {
                    throw new EmployeeBadFormatException("Invalid Contract Type");
                }
            }
            else
            {
                throw new EmployeeNotFoundException("Employee has no data");
            }
        }
    }
}
