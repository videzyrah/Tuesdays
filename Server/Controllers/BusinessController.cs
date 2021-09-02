using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tuesdays.Server.Models;
using Tuesdays.Shared;
namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessController : ControllerBase
    {
        private BusinessContext _businessContext;
        public BusinessController(BusinessContext businessContext)
        {
            _businessContext =businessContext;
        }

        // GET api/business
        [HttpGet("")]
        public ActionResult<List<Business>> Getstrings()
        {
            return _businessContext.Businesses.ToList();
        }

        // GET api/business/5
        [HttpGet("{id}")]
        public ActionResult<Business> GetstringById(int id)
        {
            return _businessContext.Businesses.FirstOrDefault(business => business.Id == id);
        }

        // POST api/business
        [HttpPost("")]
        public ActionResult<Business> Poststring(Business business)
        {
            _businessContext.Businesses.Add(business);
            _businessContext.SaveChanges();
            return business;
        }

        // PUT api/business/5
        [HttpPut("{id}")]
        public ActionResult<Business> Putstring(int id, Business business)
        {
            Business newBusiness = _businessContext.Businesses.FirstOrDefault(business => business.Id ==id);
            newBusiness.Name = business.Name;
            newBusiness.Link = business.Link;
            newBusiness.Offer = business.Offer;
            _businessContext.SaveChanges();
            return newBusiness;

        }

        // DELETE api/business/5
        [HttpDelete("{id}")]
        public void DeletestringById(int id)
        {
            Business oldBusiness = _businessContext.Businesses.FirstOrDefault(business => business.Id == id);
            _businessContext.Businesses.Remove(oldBusiness);
            _businessContext.SaveChanges();
        }
    }
}