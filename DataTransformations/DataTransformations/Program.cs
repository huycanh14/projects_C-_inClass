
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransformations
{
    class Program
    {
        class Student
        {
            public int IDStudent { get; set; }
            public string First { get; set; }
            public string Last { set; get; }
            public bool Gender { set; get; }
            public int ID { set; get; }
        }

        class Class
        {
            public int IDClass { set; get; }
            public string Name { set; get; }
        }
        static void Main(string[] args)
        {
            #region Khởi tạo
            List<Student> students = new List<Student>()
            {
                new Student {IDStudent = 1, First = "Steven", Last = "Job", Gender = true, ID = 1 },
                new Student{ IDStudent = 2, First = "Bill", Last = "Gate", Gender = true, ID = 2},
                new Student{ IDStudent = 3, First = "Chemmy", Last = "Yen", Gender = false, ID = 1},
                new Student{ IDStudent = 4, First = "Ruby", Last = "Chan", Gender = false, ID = 4},
                new Student{ IDStudent = 5, First = "Donnie", Last = "Yen", Gender = true, ID = 3}
            };

            //Create the second data source
            List<Class> classes = new List<Class>()
            {
                new Class {IDClass = 1, Name = "Class 1"},
                new Class {IDClass = 2, Name = "Class 2"},
                new Class {IDClass = 3, Name = "Class 3"},
                new Class {IDClass = 4, Name = "Class 4"},
                new Class {IDClass = 5, Name = "Class 5"},
                new Class {IDClass = 6, Name = "Class 6"}
            };

            /*var query = from st in students
                        where st.IDStudent > 2
                        orderby st.Last descending //ascending
                        select st;*/
            /*var query1 = students.Where(w=>w.IDStudent>2).ToList();
            foreach(var item in query1)
            {
                Console.WriteLine(item.First + " " + item.Last);
            }*/
            #endregion

            #region Cập nhật
            Student db = new Student
            {
                IDStudent = 6,
                First = "Truong Minh",
                Last = "Tuan",
                Gender = true,
                ID = 3
            };
            students.Add(db);
            var query = students.OrderBy(o => o.First).ToList();
            foreach (var item in query)
            {
                Console.WriteLine(item.First + " " + item.Last + " " + item.ID);
            }
            Console.WriteLine();
            var upd = students.Where(w => w.IDStudent == 5);
            foreach(var item in upd)
            {
                item.First = "TRUONG MINH";
                item.Last = "Tuan";
            }
            var query2 = students.OrderBy(o => o.First).ToList();
            foreach (var item in query2)
            {
                Console.WriteLine(item.First + " " + item.Last + " " + item.ID);
            }
            Console.WriteLine();
            #endregion

            #region Xóa dữ liệu
            var del = students.Single(w => w.IDStudent == 5);
            students.Remove(del);
            query = students.OrderBy(o => o.First).ToList();
            foreach (var item in query)
            {
                Console.WriteLine(item.First + " " + item.Last + " " + item.ID);
            }
            Console.WriteLine();
            #endregion

            #region Inner join
            var query3 = from st in students
                    join cl in classes
                    on st.ID equals cl.IDClass
                    select st;
            var querySelect = students.OrderBy(o => o.First).ToList();
            //foreach (var item in querySelect)
            //    Console.WriteLine(item.First + " " + item.Last + " " + item.ID);
            Console.WriteLine();
            #endregion

            #region Left join
            var query_leftjoin = from cl in classes
                                 join st in students
                                 on cl.IDClass equals st.ID into temp
                                 from t in temp.DefaultIfEmpty()
                                 select new { ClassName = cl.Name, Fullname = t?.First + " " + t?.Last ?? String.Empty };
            foreach(var item in query_leftjoin)
                Console.WriteLine(item.ClassName + " " + item.Fullname);
            #endregion
            Console.ReadLine();
        }
    }
}
