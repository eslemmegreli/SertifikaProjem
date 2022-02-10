using Certificate.Core.Infrastructure;
using Certificate.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Certificate.CoreCore.Infrastructure
{
    public interface ICertificateRepository : IRepository<TblCertificate>
    {
        IEnumerable<TblCertificate> GetFilter(Expression<Func<TblCertificate, bool>> expression);
    }
}
