using System.Collections.Generic;
using BOL;
using DAL;

namespace BLL
{
    public class UrlBl
    {
        private UrlDb objDb;

        public UrlBl()
        {
            objDb = new UrlDb();
        }

        public IEnumerable<tbl_Url> GetAll()
        {
            return objDb.GetAll();
        }

        public tbl_Url GetById(int Id)
        {
            return objDb.GetById(Id);
        }

        public void Insert(tbl_Url url)
        {
            objDb.Insert(url);
        }

        public void Delete(int Id)
        {
            objDb.Delete(Id);
        }

        public void Update(tbl_Url url)
        {
            objDb.Update(url);
        }
    }
}
