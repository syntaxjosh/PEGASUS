using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pegasus.Models.Profiles;
using Pegasus.Repository;
using Pegasus.Services.Maintenance;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pegasus.Api.Agent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgentController : ControllerBase
    {
        private readonly IUserAgentService _agentservice;
        public AgentController(IUserAgentService agentservice)
        {
            _agentservice = agentservice;
        }
        // GET: api/<AgentController>
        [HttpGet]
        public IEnumerable<AgentModel> Get()
        {
            return _agentservice.GetAgents();
        }

        // GET api/<AgentController>/5
        [HttpGet("{id}")]
        public AgentModel Get(int id)
        {
            return _agentservice.GetAgent(id);
        }

        // POST api/<AgentController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AgentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AgentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
