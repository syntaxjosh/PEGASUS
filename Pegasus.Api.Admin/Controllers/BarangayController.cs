using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pegasus.Models.Maintenance;
using Pegasus.Models.Profiles;
using Pegasus.Services.Maintenance;
using Pegasus.Services.Profile;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pegasus.Api.Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BarangayController : ControllerBase
    {
        private readonly IBarangayProfile _brgyprofile;
        private readonly IPersonProfileService _personprofile;
        public BarangayController(IBarangayProfile brgyprofile, IPersonProfileService personprofile)
        {
            _brgyprofile = brgyprofile;
            _personprofile = personprofile;
        }

        // GET: api/<BarangayController>
        [HttpGet]
        public List<BarangayModel> GetBarangyList()
        {
            return _brgyprofile.GetBarangays();
        }
        [HttpGet]
        [Route("GetBarangayLists")]
        public List<BarangayModel> GetBarangyLists()
        {
            return _brgyprofile.GetBarangays();
        }

        // GET api/<BarangayController>/5
        [HttpGet("{id}")]
        public  ActionResult<BarangayModel> Get(int id)
        {
            return  _brgyprofile.GetBarangay(id);
        }
        

        // POST api/<BarangayController>
        [HttpPost]
        public void Post(BarangayModel model)
        {
            _brgyprofile.CreateBarangay(model);
        }

        // PUT api/<BarangayController>/5
        
        public void Put(BarangayModel model)
        {
            _brgyprofile.UpdateBarangay(model);
        }

        // DELETE api/<BarangayController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
