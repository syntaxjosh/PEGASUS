using Pegasus.Models.Maintenance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Services.Maintenance
{
    public interface ILguProfileService
    {
        IEnumerable<LguProfileModel> GetLguProfiles();
        LguProfileModel GetLguProfile(int id);

        LguProfileModel GetLguProfile(string name);

        void CreateLguProfile(LguProfileModel model);

        void UpdateLguProfile(LguProfileModel model);

        void RemoveLguProfile(int id);

    }
}
