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
    public class OGRENCI_NOTManager : IOGRENCI_NOTService
    {

        private readonly IOGRENCI_NOTDal _ogrencinotDal;

        public OGRENCI_NOTManager(IOGRENCI_NOTDal ogrencinotDal)
        {
            _ogrencinotDal = ogrencinotDal;
        }

        public void TDelete(OGRENCI_NOT t)
        {
            _ogrencinotDal.Delete(t);
        }

        public OGRENCI_NOT TGetByID(int id)
        {
            return _ogrencinotDal.GetByID(id);
        }

        public List<OGRENCI_NOT> TGetList()
        {
            return _ogrencinotDal.GetList();
        }

        public void TInsert(OGRENCI_NOT t)
        {
            _ogrencinotDal.Insert(t);
        }

        public void TUpdate(OGRENCI_NOT t)
        {
            _ogrencinotDal.Update(t);
        }
    }
}
