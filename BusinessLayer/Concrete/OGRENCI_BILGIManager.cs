using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class OGRENCI_BILGIManager : IOGRENCI_BILGIService
    {
        private readonly IOGRENCI_BILGIDal _ogrencibilgiDal;

        public OGRENCI_BILGIManager(IOGRENCI_BILGIDal ogrencibilgiDal)
        {
            _ogrencibilgiDal = ogrencibilgiDal;
        }

        public void TDelete(OGRENCI_BILGI t)
        {
            _ogrencibilgiDal.Delete(t);
        }

        public OGRENCI_BILGI TGetByID(int id)
        {
            return _ogrencibilgiDal.GetByID(id);
        }

        public List<OGRENCI_BILGI> TGetList()
        {
            return _ogrencibilgiDal.GetList();
        }

        public void TInsert(OGRENCI_BILGI t)
        {
            _ogrencibilgiDal.Insert(t);
        }

        public void TUpdate(OGRENCI_BILGI t)
        {
            _ogrencibilgiDal.Update(t);
        }
    }
}
