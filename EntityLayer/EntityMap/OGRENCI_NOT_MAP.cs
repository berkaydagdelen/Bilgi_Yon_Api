using EntityLayer.Concrete;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.EntityMap
{
    public class OGRENCI_NOT_MAP:ClassMap<OGRENCI_NOT>
    {
        public OGRENCI_NOT_MAP()
        {
            Table("OGRENCI_NOT");
            Id(p => p.ID).GeneratedBy.Identity();
            Map(p => p.NOTU);
            Map(p => p.OGRENCI_NO);
        }
    }
}
