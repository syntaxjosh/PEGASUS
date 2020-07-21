using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pegasus.Models.Profiles;
using Pegasus.Services.Profile;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pegasus.Api.Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecondContactsController : ControllerBase
    {
        private IPersonProfileService _personService;
        public SecondContactsController(IPersonProfileService personService)
        {
            _personService = personService;
        }
        // GET: api/<BarangayController>
        [HttpGet]
        public IEnumerable<PersonProfilesModel> GetPersonList()
        {
            return _personService.GetPersonProfiles();
        }

        [HttpGet("{id}")]
        public ActionResult<PersonProfilesModel> Get(int id) { 
            return _personService.GetPersonProfiles().FirstOrDefault(x=>x.PrincipalPersonId==id);
        }
        // GET api/<BarangayController>/5
        //[HttpGet("{id}")]
        //public ActionResult<PersonProfilesModel> Get(int id)
        //{
        //    return _personService.GetPersonProfile(id);
        //}

        

        // POST api/<BarangayController>
        [HttpPost]
        public void Post(PersonProfilesModel model)
        {
            _personService.CreatePersonProfile(model);
        }

        // PUT api/<BarangayController>/5
        [HttpPut("{id}")]
        public void Put(int id, PersonProfilesModel model)
        {
            _personService.UpdatePersonProfile(model);
        }

        // DELETE api/<BarangayController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
