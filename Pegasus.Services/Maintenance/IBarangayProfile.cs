using Pegasus.Models.Maintenance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Services.Maintenance
{
    public interface IBarangayProfile
    {
        List<BarangayModel> GetBarangays();
        BarangayModel GetBarangay(int id);

        BarangayModel GetBarangay(string name);

        void CreateBarangay(BarangayModel model);

        void UpdateBarangay(BarangayModel model);

        void RemoveBarangay(int id);

    }
}
