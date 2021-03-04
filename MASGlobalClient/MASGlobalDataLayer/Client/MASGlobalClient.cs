using MASGlobalDataLayer.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MASGlobalDataLayer.Client
{
    public class MASGlobalClient
    {
        public string Api { get; private set; }

        public MASGlobalClient( string pApi )
        {
            Api = pApi;
        }

        public List<EmployeePOCO> GetEmployees()
        {
            List<EmployeePOCO> employees = null;
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = httpClient.GetStringAsync(new Uri(Api)).Result;

                employees = JsonConvert.DeserializeObject<List<EmployeePOCO>>(response);
            }

            return employees;
        }

        public EmployeePOCO GetEmployeeById( int pId )
        {
            EmployeePOCO theEmployee = null;
            var employees = GetEmployees();
            if( employees != null )
            {
                theEmployee = (from e in employees
                                where e.id == pId
                                select e).FirstOrDefault();
            }

            return theEmployee;
        }
    }
}
