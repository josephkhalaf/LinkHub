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

        public IEnumerable<tbl_url> GetAll()
        {
            return objDb.GetAll();
        }

        public tbl_url GetById(int Id)
        {
            return objDb.GetById(Id);
        }

        public void Insert(tbl_url url)
        {
            objDb.Insert(url);
        }

        public void Delete(int Id)
        {
            objDb.Delete(Id);
        }

        public void Update(tbl_url url)
        {
            objDb.Update(url);
        }
    }
}
