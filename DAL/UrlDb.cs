using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BOL;

namespace DAL
{
    public class UrlDb
    {
        private LinkHubModel db;

        public UrlDb()
        {
            db = new LinkHubModel();
        }

        public IEnumerable<tbl_url> GetAll()
        {
            return db.tbl_url.ToList();
        }

        public tbl_url GetById(int Id)
        {
            return db.tbl_url.Find(Id);
        }

        public void Insert(tbl_url url)
        {
            db.tbl_url.Add(url);
            Save();
        }

        public void Delete(int Id)
        {
            tbl_url url = db.tbl_url.Find(Id);
            if (url != null)
            {
                db.tbl_url.Remove(url);
                Save();
            }
        }

        public void Update(tbl_url url)
        {
            db.Entry(url).State = EntityState.Modified;
        }

        private void Save()
        {
            db.SaveChanges();
        }
    }
}
