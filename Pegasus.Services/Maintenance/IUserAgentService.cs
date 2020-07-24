using Pegasus.Models.Profiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pegasus.Services.Maintenance
{
    public interface IUserAgentService
    {
        IEnumerable<AgentModel> GetAgents();
        AgentModel GetAgent(int id);
        void CreateAgent(AgentModel model);
        void UpdateAgent(AgentModel model);
    }
}
