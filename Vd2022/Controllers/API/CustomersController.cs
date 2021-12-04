using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vd2022.Models;

namespace Vd2022.Controllers.API
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /api/customers
        [HttpGet]
        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers.ToList();
        }

        // GET /api/customers/1
        [HttpGet]
        public Customer GetCustomer (int id)
        {
            return _context.Customers.Find(id);
        }

        //POST
        [HttpPost]
        public Customer CreateCustomer(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return customer;
        }

        //PUT api/customers/1
        [HttpPut]
        public void UpdateCustomer(int id, Customer customer)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            var customerinDb = _context.Customers.Find(id);
            if (customerinDb==null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            customerinDb.Name = customer.Name;
            customerinDb.BirthDate = customer.BirthDate;
            customerinDb.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;
            customerinDb.MemberShipTypeId = customer.MemberShipTypeId;
            _context.SaveChanges();
            
        }

        //GET /api/customers/1
        [HttpDelete]
        public void DeleteCustomer(int id)
        {
            var customerinDb = _context.Customers.Find(id);
            if (customerinDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            _context.Customers.Remove(customerinDb);
            _context.SaveChanges();
            
        }


    }
}
