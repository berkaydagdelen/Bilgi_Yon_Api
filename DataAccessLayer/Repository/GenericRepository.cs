using DataAccessLayer.Abstract;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {

        private readonly ISessionFactory _sessionFactory;

        public GenericRepository(ISessionFactory sessionFactory)
        {

            _sessionFactory = sessionFactory;
        }

        public void Delete(T t)
        {
            using (var session = _sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Delete(t);
                    transaction.Commit();
                }
            }
        }



        public T GetByID(int id)
        {
            using (var session = _sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var entity = session.Get<T>(id);
                    transaction.Commit();
                    return entity;
                }
            }

        }

        public List<T> GetList()
        {
            using (var session = _sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var list = session.Query<T>().ToList();
                    transaction.Commit();
                    return list;
                }
            }
        }

        public void Insert(T t)
        {
            using (var session = _sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Save(t);
                    transaction.Commit();
                }
            }
        }

        public void Update(T t)
        {
            using (var session = _sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Update(t);
                    transaction.Commit();
                }
            }
        }
    }
}
