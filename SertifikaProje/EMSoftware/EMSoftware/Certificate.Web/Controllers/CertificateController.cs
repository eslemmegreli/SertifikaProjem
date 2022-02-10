using Certificate.CoreCore.Infrastructure;
using CertificateProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Certificate.Web.Controllers
{
    public class CertificateController : Controller
    {
        private readonly ICertificateRepository _certificateRepository;

        public CertificateController(ICertificateRepository certificateRepository)
        {
            _certificateRepository = certificateRepository;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UserList(int? cno)
        {
            CertificateViewModel vm = new CertificateViewModel()
            {
                certificates = _certificateRepository.GetFilter(x => x.CertificateID == cno).ToList()
            };

            return View(vm);   
        }
    }
}