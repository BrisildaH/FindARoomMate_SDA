using FindMeARoomate.DataLayer.DatabaseContext;
using FindMeARoomate.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMeARoomate.DataLayer.Repositories
{
    public class ApplicationRepository

    {
      
            public void AddApplication(Application application)
            { // DbContext Add Method
                var dbContext = new FindMeARoomateContext();
                dbContext.Applications.Add(application);
                dbContext.SaveChanges();
            }
            // Get All Application
            public List<Application> GetAllApplication()
            {
                var context = new FindMeARoomateContext();
                var applications = context.Applications.ToList();

                return applications;
            }
            // Get By ID
            public Application FindByID(int id)
            {
                try
                {
                    var dbContext = new FindMeARoomateContext();
                    var application = dbContext.Applications.Where(p => p.ID == id)
                        .FirstOrDefault();
                    return application;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw ex;
                }
            }
            //Update
            //Remove
            public void DeleteApplication(Application application)
            {
                try
                {
                    var dbContext = new FindMeARoomateContext();
                    dbContext.Applications.Remove(application);
                    dbContext.SaveChanges();
                    Console.WriteLine("Application removed");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error : " + ex.Message.ToString());
                    throw ex;
                }
            }
            public void UpdateApplication(Application application)
            {
                try
                {
                    var dbContext = new FindMeARoomateContext();
                    dbContext.Applications.Update(application);
                    dbContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw ex;
                }
            }
        }
    }

