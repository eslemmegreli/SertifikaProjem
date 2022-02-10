using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Certificate.Data
{
    public class TblCertificate
    {
        public int ID { get; set; }
        public int CertificateID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}