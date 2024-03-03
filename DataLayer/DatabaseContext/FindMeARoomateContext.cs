using FindMeARoomate.DataLayer.Entities;
using FindMeARoomate.DataLayer.Entities.NewFolder;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMeARoomate.DataLayer.DatabaseContext
{
    public class FindMeARoomateContext: DbContext
    {

        public FindMeARoomateContext() { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Dormitory> Dormitories { get; set; }
        public DbSet<DormitoryStudent> DormitoryStudents { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Announcement> Announcements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-I3P814Q\\SQLEXPRESS;Initial Catalog=FindMeARoomate;Integrated Security=True; TrustServerCertificate=True");
        }
    }
}
  



