using MASGlobalBusinessLayer;
using MASGlobalBusinessLayer.Entities;
using MASGlobalBusinessLayer.Exceptions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MASGlobalFrontLayer.ApiControllers
{
    public class EmployeesController : ApiController
    {
        // GET api/<controller>
        public List<EmployeeDTO> Get()
        {
            var masGlobalApiEndpoint = ConfigurationManager.AppSettings["MASGlobalApiEndpoint"];

            List<EmployeeDTO> _employees = null;
            try
            {
                MASGlobalEmployeesManager manager = new MASGlobalEmployeesManager(masGlobalApiEndpoint);

                _employees = manager.GetEmployees();
            }
            catch( Exception ex )
            {
                throw new HttpResponseException(HttpStatusCode.InternalServerError);
            }

            return _employees;
        }

        // GET api/<controller>/5
        public EmployeeDTO Get(int id)
        {
            var masGlobalApiEndpoint = ConfigurationManager.AppSettings["MASGlobalApiEndpoint"];

            EmployeeDTO _theEmployee = null;
            try
            {
                MASGlobalEmployeesManager manager = new MASGlobalEmployeesManager(masGlobalApiEndpoint);

                _theEmployee = manager.GetEmployeeById(id);
            }
            catch (EmployeeNotFoundException notFoundEx)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(HttpStatusCode.InternalServerError);
            }

            return _theEmployee;
        }

        // POST api/<controller>
        public void Post([FromBody] EmployeeDTO _employee)
        {
            throw new HttpResponseException(HttpStatusCode.NotImplemented);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] EmployeeDTO _employee)
        {
            throw new HttpResponseException(HttpStatusCode.NotImplemented);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            throw new HttpResponseException(HttpStatusCode.NotImplemented);
        }
    }
}