using Pegasus.Data;
using Pegasus.Models.Profiles;
using Pegasus.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pegasus.Services.Maintenance
{
    public class UserAgentService : IUserAgentService
    {
        readonly IRepository<UserAgents> _repoUserAgent;
        public UserAgentService(IRepository<UserAgents> repoUserAgent)
        {
            _repoUserAgent = repoUserAgent;
        }
        public void CreateAgent(AgentModel model)
        {
            _repoUserAgent.AddAsync(new UserAgents
            {
                Fullname = model.Fullname,
                PIN = GenerateRandomNo(),
                Department = model.Department
            });
        }

        public AgentModel GetAgent(int id)
        {
           var data =  _repoUserAgent.GetAll().FirstOrDefault(x => x.Id == id);
            return new AgentModel
            {
                Id = data.Id,
                Department = data.Department,
                Fullname = data.Fullname,
                PIN = data.PIN
            };
        }

        public IEnumerable<AgentModel> GetAgents()
        {
            return _repoUserAgent.GetAll().Select(x => new AgentModel
            {
                Id = x.Id,
                Department = x.Department,
                Fullname = x.Fullname,
                PIN = x.PIN
            });
        }

        public void UpdateAgent(AgentModel model)
        {
            _repoUserAgent.UpdateAsync(new UserAgents
            {
                Fullname = model.Fullname,
                PIN =model.PIN,
                Department = model.Department
            });
        }
        private readonly Random _rdm = new Random();
        public int GenerateRandomNo()
        {
            int _min = 1000;
            int _max = 9999;
            
            return _rdm.Next(_min, _max);
        }
    }
}
