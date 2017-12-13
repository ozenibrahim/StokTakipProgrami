using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.Dal.DataAccessLayer
{
    // Burayı sadece diger siniflara miras verebilmek icin tanımladık ve implement oluşturmak icinn.
   public abstract class DataAccessLayer<T> 
    {
        // Ekleme / Kaydetme işlemim için 
        public abstract int Save(T instance);

        // Güncelleme işlemim için 
        public abstract int Update(T instance);

        // Silme işlemim için -> ( Id'ye göre silecek ) 
        public abstract int Delete(object instanceId);

        // Listeleme işlemim için 
        public abstract List<T> List();

        // Search işlemim için 
        public abstract List<T> Search(string search);
       
    }
}
