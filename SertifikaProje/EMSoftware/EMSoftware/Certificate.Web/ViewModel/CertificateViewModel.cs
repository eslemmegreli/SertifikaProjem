using Certificate.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CertificateProject.ViewModel
{
    public class CertificateViewModel
    {
        public IEnumerable<TblCertificate> certificates { get; set; }
        public TblCertificate certificate { get; set; }
    }
}