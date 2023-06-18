using EntityLayer.Concrete;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.EntityMap
{
    public class OGRENCI_BILGI_MAP : ClassMap<OGRENCI_BILGI>
    {
        public OGRENCI_BILGI_MAP()
        {
            Table("OGRENCI_BILGI");
            Id(p => p.OGRENCI_NO).GeneratedBy.Identity();
            Map(p => p.AD);
            Map(p => p.SOYAD);
        }
    }
}
