﻿using Pegasus.Data;
using Pegasus.Models.Profiles;
using Pegasus.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Services.Profile
{
    public class PersonProfileService : IPersonProfileService
    {
        private readonly IRepository<PersonProfile> _repoPersonProfile;

        public PersonProfileService(IRepository<PersonProfile> repoPersonProfile)
        {
            _repoPersonProfile = repoPersonProfile;
        }

        public void CreatePersonProfile(PersonProfilesModel model)
        {
            _repoPersonProfile.AddAsync(new PersonProfile
            {
                Fullname = model.Fullname,
                LguId = model.LguId,
                BrgyId = model.BgryId,
                PersonStatus = model.PersonStatus,
                PrincipalPersonId = model.PrincipalPersonId,
                QDays = model.QDays,
                QDateStarted = model.QDateStarted,
                QDateEnded = model.QDateEnded,
                PicPath = model.PicPath,
                DateCreated = model.DateCreated,
                QrCode = model.QrCode,
                Contact = model.Contact,
                 Address = model.Address

            });
        }

        public List<PersonProfilesModel> GetContacts(int id)
        {
            return _repoPersonProfile.GetAll().Select(x => new PersonProfilesModel
            {
                 Id =x.Id,
                  Fullname = x.Fullname,
                LguId = x.LguId,
                BgryId = x.BrgyId,
                PersonStatus = x.PersonStatus,
                PrincipalPersonId = x.PrincipalPersonId,
                QDays = x.QDays,
                QDateStarted = x.QDateStarted,
                QDateEnded = x.QDateEnded,
                PicPath = x.PicPath,
                DateCreated = x.DateCreated,
                QrCode = x.QrCode,
                Contact =x.Contact,
                 Address =x.Address,
                Barangay = new Models.Maintenance.BarangayModel
                {
                    Id = x.Brgy.Id,
                    LguId = x.LguId,
                    BarangayAddress = x.Brgy.BarangayAddress,
                    BarangayName = x.Brgy.BarangayName,
                }
            }).Where(x => x.PrincipalPersonId == id).ToList();
        }
       
        public PersonProfilesModel GetPersonProfile(int id)
        {
            return _repoPersonProfile.GetAll().Select(x => new PersonProfilesModel
            {
                Id = x.Id,
                Fullname = x.Fullname,
                LguId = x.LguId,
                BgryId = x.BrgyId,
                PersonStatus = x.PersonStatus,
                PrincipalPersonId = x.PrincipalPersonId,
                QDays = x.QDays,
                QDateStarted = x.QDateStarted,
                QDateEnded = x.QDateEnded,
                PicPath = x.PicPath,
                DateCreated = x.DateCreated,
                QrCode = x.QrCode,
                Address =x.Address,
                 Contact =x.Contact
            }).FirstOrDefault(x => x.Id == id);
        }

        public PersonProfilesModel GetPersonProfile(string name)
        {
            return _repoPersonProfile.GetAll().Select(x => new PersonProfilesModel
            {
                Id = x.Id,
                Fullname = x.Fullname,
                LguId = x.LguId,
                BgryId = x.BrgyId,
                PersonStatus = x.PersonStatus,
                PrincipalPersonId = x.PrincipalPersonId,
                QDays = x.QDays,
                QDateStarted = x.QDateStarted,
                QDateEnded = x.QDateEnded,
                PicPath = x.PicPath,
                DateCreated = x.DateCreated,
                QrCode = x.QrCode,
                Address = x.Address,
                Contact = x.Contact
            }).FirstOrDefault(x => x.Fullname == name);
        }

        public IEnumerable<PersonProfilesModel> GetPersonProfiles()
        {
            return _repoPersonProfile.GetAll().Select(x => new PersonProfilesModel
            {
                Id = x.Id,
                Fullname = x.Fullname,
                LguId = x.LguId,
                BgryId = x.BrgyId,
                PersonStatus = x.PersonStatus,
                PrincipalPersonId = x.PrincipalPersonId,
                QDays = x.QDays,
                QDateStarted = x.QDateStarted,
                QDateEnded = x.QDateEnded,
                PicPath = x.PicPath,
                DateCreated = x.DateCreated,
                QrCode = x.QrCode,
                Address = x.Address,
                Contact = x.Contact,
                Barangay =new Models.Maintenance.BarangayModel
                {
                    Id = x.Brgy.Id,
                    LguId = x.LguId,
                    BarangayAddress = x.Brgy.BarangayAddress,
                    BarangayName = x.Brgy.BarangayName,
                }
            });
        }

        public void RemovePersonProfile(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdatePersonProfile(PersonProfilesModel model)
        {
            _repoPersonProfile.UpdateAsync(new PersonProfile
            {
                Id = model.Id,
                Fullname = model.Fullname,
                LguId = model.LguId,
                BrgyId = model.BgryId,
                PersonStatus = model.PersonStatus,
                PrincipalPersonId = model.PrincipalPersonId,
                QDays = model.QDays,
                QDateStarted = model.QDateStarted,
                QDateEnded = model.QDateEnded,
                PicPath = model.PicPath,
                DateCreated = model.DateCreated,
                QrCode = model.QrCode,
                Address = model.Address,
                Contact = model.Contact

            });
        }
    }
}
