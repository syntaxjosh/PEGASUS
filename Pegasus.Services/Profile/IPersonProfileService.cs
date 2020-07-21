using Pegasus.Models.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Services.Profile
{
    public interface IPersonProfileService
    {
        IEnumerable<PersonProfilesModel> GetPersonProfiles();
        PersonProfilesModel GetPersonProfile(int id);

        List<PersonProfilesModel> GetContacts(int id);

        PersonProfilesModel GetPersonProfile(string name);

        void CreatePersonProfile(PersonProfilesModel model);

        void UpdatePersonProfile(PersonProfilesModel model);

        void RemovePersonProfile(int id);

    }
}
