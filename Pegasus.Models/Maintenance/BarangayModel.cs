using Pegasus.Models.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Models.Maintenance
{
    public class BarangayModel
    {
        public int Id { get; set; }
        public string BarangayName { get; set; }
        public string BarangayAddress { get; set; }
        public string BarangayLocation { get; set; }
        public string BarangayLogoPath { get; set; }
        public string BarangayQrCode { get; set; }
        public string BarangayLgu { get; set; }
        public int? LguId { get; set; }
        public DateTime? DateCreated { get; set; }

        public List<PersonProfilesModel> persons { get; set; }
    }

}
