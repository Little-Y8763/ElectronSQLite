using ElectronSQLite.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronSQLite.Models
{
    public class DummyData
    {
        public static void Initialize(ApplicationDbContext db)
        {
            if (!db.Students.Any())
            {
                db.Students.Add(new Student
                {
                    FirstName = "Toshi",
                    LastName = "Hi",
                    School = "Engineering",
                    StartDate = Convert.ToDateTime("2021/09/08")
                });
                db.Students.Add(new Student
                {
                    FirstName = "Toshi",
                    LastName = "HiHi",
                    School = "Engineering",
                    StartDate = Convert.ToDateTime("2021/09/07")
                });
                db.SaveChanges();
            }
        }
    }
}
