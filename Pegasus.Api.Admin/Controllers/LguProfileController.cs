using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pegasus.Models.Maintenance;
using Pegasus.Services.Maintenance;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pegasus.Api.Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LguProfileController : ControllerBase
    {
        private readonly ILguProfileService _lguprofile;
        public LguProfileController(ILguProfileService lguprofile)
        {
            _lguprofile = lguprofile;
        }

        // GET: api/<BarangayController>
        [HttpGet]
        public IEnumerable<LguProfileModel> GetLguList()
        {
            return _lguprofile.GetLguProfiles();
        }

        // GET api/<BarangayController>/5
        [HttpGet("{id}")]
        public ActionResult<LguProfileModel> Get(int id)
        {
            return _lguprofile.GetLguProfile(id);
        }

        //[HttpGet("{name}")]
        //public ActionResult<LguProfileModel> GetName(string name)
        //{
        //    return _lguprofile.GetLguProfile(name);
        //}

        // POST api/<BarangayController>
        [HttpPost]
        public void Post(LguProfileModel model)
        {
            _lguprofile.CreateLguProfile(model);
        }

        // PUT api/<BarangayController>/5
        
        public void Put(LguProfileModel model)
        {
            _lguprofile.UpdateLguProfile(model);
        }

        // DELETE api/<BarangayController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
