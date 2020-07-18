using Pegasus.Models.Maintenance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Models.Profiles
{
    public class PersonProfilesModel
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public int? LguId { get; set; }
        public int? BgryId { get; set; }
        public string QrCode { get; set; }
        public string PicPath { get; set; }
        public DateTime? DateCreated { get; set; }
      
        public int? PrincipalPersonId { get; set; }
        public int? QDays { get; set; }
        public DateTime? QDateStarted { get; set; }
        public DateTime? QDateEnded { get; set; }
        public string PersonStatus { get; set; }

        public BarangayModel Barangay { get; set; }
        public LguProfileModel Lgu { get; set; }

    }
}
