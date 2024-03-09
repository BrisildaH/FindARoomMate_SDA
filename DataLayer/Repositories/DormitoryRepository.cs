using FindMeARoomate.DataLayer.DatabaseContext;
using FindMeARoomate.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMeARoomate.DataLayer.Repositories
{
    public class DormitoryRepository
    {
        //public void AddDormitory(Dormitory dormitory)
        //{ // DbContext Add Method
        //    var dbContext = new FindMeARoomateContext();
        //    dbContext.Dormitories.Add(dormitory);
        //    dbContext.SaveChanges();
        //}
        // Get All Dormitory
        public List<Dormitory> GetAllDormitory()
        {
            var context = new FindMeARoomateContext();
            var dormitories = context.Dormitories.ToList();

            return dormitories;
        }
        // Get By ID
        public Dormitory FindByID(int id)
        {
            try
            {
                var dbContext = new FindMeARoomateContext();
                var dormitory = dbContext.Dormitories.Where(d => d.ID == id)
                    .FirstOrDefault();
                return dormitory;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        //Update
        //Remove
        //public void DeleteStudent(Student student)
        //{
        //    try
        //    {
        //        var dbContext = new FindMeARoomateContext();
        //        dbContext.Students.Remove(student);
        //        dbContext.SaveChanges();
        //        Console.WriteLine("Student removed");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Error : " + ex.Message.ToString());
        //        throw ex;
        //    }
        //}
        //public void UpdateStudent(Student student)
        //{
        //    try
        //    {
        //        var dbContext = new FindMeARoomateContext();
        //        dbContext.Students.Update(student);
        //        dbContext.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        throw ex;
        //    }
        //}
    }
}
    