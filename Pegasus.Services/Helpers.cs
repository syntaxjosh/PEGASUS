using Pegasus.Data;
using Pegasus.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pegasus.Services
{
    public class Helpers
    {
        private readonly IRepository<Barangay> _repoBarangay;
        private readonly IRepository<LguProfile> _repoLgu;
       
        public Helpers(IRepository<Barangay> repoBarangay, IRepository<LguProfile> repoLgu)
        {
            _repoBarangay = repoBarangay;
            _repoLgu = repoLgu;
        }

        
    }
}
