﻿using System.Collections.Generic;
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

        public IEnumerable<tbl_Url> GetAll()
        {
            return db.tbl_Url.ToList();
        }

        public tbl_Url GetById(int Id)
        {
            return db.tbl_Url.Find(Id);
        }

        public void Insert(tbl_Url url)
        {
            db.tbl_Url.Add(url);
            Save();
        }

        public void Delete(int Id)
        {
            tbl_Url url = db.tbl_Url.Find(Id);
            if (url != null)
            {
                db.tbl_Url.Remove(url);
                Save();
            }
        }

        public void Update(tbl_Url url)
        {
            db.Entry(url).State = EntityState.Modified;
        }

        private void Save()
        {
            db.SaveChanges();
        }
    }
}
