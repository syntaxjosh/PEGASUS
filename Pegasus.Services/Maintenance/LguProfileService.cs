using Pegasus.Data;
using Pegasus.Models.Maintenance;
using Pegasus.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Services.Maintenance
{
    public class LguProfileService : ILguProfileService
    {
        readonly IRepository<LguProfile> _repoLguProfile;
        public LguProfileService(IRepository<LguProfile> repoLguProfile)
        {
            _repoLguProfile = repoLguProfile;
        }
        public void CreateLguProfile(LguProfileModel model)
        {
            _repoLguProfile.AddAsync(new LguProfile
            {
                LguAddress = model.LguAddress,
                LguLocation = model.LguLocation,
                LguLogoPath = model.LguLogoPath,
                LguName = model.LguName,
                LguQrCode = model.LguQrCode,
                DateCreated = DateTime.Now
            });

        }

        public LguProfileModel GetLguProfile(int id)
        {
            return _repoLguProfile.GetAll().Select(x => new LguProfileModel
            {
                Id = x.Id,
                LguAddress = x.LguAddress,
                LguLocation = x.LguLocation,
                LguLogoPath = x.LguLogoPath,
                LguName = x.LguName,
                LguQrCode = x.LguQrCode,
                DateCreated = x.DateCreated
            }).FirstOrDefault(x=>x.Id==id);
        }

        public LguProfileModel GetLguProfile(string name)
        {
            return _repoLguProfile.GetAll().Select(x => new LguProfileModel
            {
                Id = x.Id,
                LguAddress = x.LguAddress,
                LguLocation = x.LguLocation,
                LguLogoPath = x.LguLogoPath,
                LguName = x.LguName,
                LguQrCode = x.LguQrCode,
                DateCreated = x.DateCreated
            }).FirstOrDefault(x => x.LguName == name);
        }

        public IEnumerable<LguProfileModel> GetLguProfiles()
        {
            return _repoLguProfile.GetAll().Select(x => new LguProfileModel
            {
                Id = x.Id,
                LguAddress = x.LguAddress,
                LguLocation = x.LguLocation,
                LguLogoPath = x.LguLogoPath,
                LguName = x.LguName,
                LguQrCode = x.LguQrCode,
                DateCreated = x.DateCreated
            }).ToList();
        }

        public void RemoveLguProfile(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateLguProfile(LguProfileModel model)
        {
            _repoLguProfile.UpdateAsync(new LguProfile
            {
                Id = model.Id,
                LguAddress = model.LguAddress,
                LguLocation = model.LguLocation,
                LguLogoPath = model.LguLogoPath,
                LguName = model.LguName,
                LguQrCode = model.LguQrCode,
                DateCreated = DateTime.Now
            });
        }
    }
}
