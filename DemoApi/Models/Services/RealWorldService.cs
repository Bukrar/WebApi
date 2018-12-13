using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoApi.Models.Services
{
    public class RealWorldService
    {
        private RealWordEntities _db = new RealWordEntities();

        public IQueryable<Article> GetAll()
        {
            return this._db.Set<Article>().AsQueryable();
        }

    }
}