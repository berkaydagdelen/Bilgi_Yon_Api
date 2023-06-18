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
    public class NHOGRENCI_NOTDal : GenericRepository<OGRENCI_NOT>, IOGRENCI_NOTDal
    {
        public NHOGRENCI_NOTDal(ISessionFactory sessionFactory) : base(sessionFactory)
        {
        }
    }
}
