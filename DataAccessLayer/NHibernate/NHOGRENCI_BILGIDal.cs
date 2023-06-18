using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.NHibernate
{
    public class NHOGRENCI_BILGIDal : GenericRepository<OGRENCI_BILGI>, IOGRENCI_BILGIDal
    {
        public NHOGRENCI_BILGIDal(ISessionFactory sessionFactory) : base(sessionFactory)
        {
        }
    }
}
