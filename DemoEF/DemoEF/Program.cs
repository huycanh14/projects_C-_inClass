using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            webOnlineEntities db = new webOnlineEntities();
            #region Selecting
            var query = db.News_Category.OrderBy(o => o.CateName).ToList();
            foreach(var item in query)
            {
                Console.WriteLine(item.CateName + " " + item.cOrder);
            }
            #endregion

            #region Insert
            /*News_Category news = new News_Category();
            news.CateName = "News";
            news.cLink = "news";
            news.cOrder = 7;
            news.cActive = false;
            db.News_Category.Add(news);
            db.SaveChanges();*/
            #endregion

            #region Update
            /*var res = db.News_Category
                        .Where(w => w.IDCategory == 8)
                        .SingleOrDefault();
            if(res != null)
            {
                res.CateName = "Tin tức sự kiện";
                res.cActive = true;
            }
            db.SaveChanges(); */
            #endregion

            #region Delete
            //var res = db.News_Category.SingleOrDefault(s => s.IDCategory == 8);
            //if(res != null)
            //{
            //    db.News_Category.Remove(res);
            //}
            //db.SaveChanges();
            #endregion

            #region
            var res = db.sp_getList_News_Category();
            foreach(var item in res)
            {
                Console.WriteLine(item.CateName);
            }
            #endregion
            Console.ReadLine();
        }
    }
}
