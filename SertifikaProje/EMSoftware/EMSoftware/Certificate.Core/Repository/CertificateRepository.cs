using Certificate.CoreCore.Infrastructure;
using Certificate.Data;
using Certificate.Data.DataContext;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CertificateCore.Repository
{
    public class CertificateRepository : ICertificateRepository
    {
        private readonly EMContext _context = new EMContext();
        public TblCertificate Get(Expression<Func<TblCertificate, bool>> expression)
        {
            return _context.TblCertificates.FirstOrDefault(expression);
        }

        public IEnumerable<TblCertificate> GetAll()
        {
            return _context.TblCertificates.Select(x => x);
        }

        public TblCertificate GetById(int Id)
        {
            return _context.TblCertificates.FirstOrDefault(x => x.ID == Id);
        }

        public IQueryable<TblCertificate> GetMany(Expression<Func<TblCertificate, bool>> expression)
        {
            return _context.TblCertificates.Where(expression);
        }

        public void Insert(TblCertificate obj)
        {
            _context.TblCertificates.Add(obj);
        }
        public void Delete(int Id)
        {
            var TblCertificate = GetById(Id);
            if (TblCertificate != null)
            {
                _context.TblCertificates.Remove(TblCertificate);
            }
        }
        public void Update(TblCertificate obj)
        {
            _context.TblCertificates.AddOrUpdate();
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        public int count()
        {
            return _context.TblCertificates.Count();
        }

        public IEnumerable<TblCertificate> GetFilter(Expression<Func<TblCertificate, bool>> expression)
        {
            return _context.TblCertificates.Where(expression);
        }
    }
}
