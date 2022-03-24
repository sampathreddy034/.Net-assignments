using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ASP2;

namespace ASP2.Controllers
{
    public class EmployeesController : ApiController
    {
        CaseStudyEntities1 db = new CaseStudyEntities1();

        // GET: api/Employees
        public IQueryable<Employee> GetEmployees()
        {
            return db.Employees;
        }
      
        [ResponseType(typeof(Employee))]
       

        public IHttpActionResult GetEmployeeSalById(int eid)
        {
            var details = db.GetSalaryById(eid).ToList();
            return Ok(details);
        }



    }
}