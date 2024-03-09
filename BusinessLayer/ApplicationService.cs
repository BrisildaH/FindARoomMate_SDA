using FindMeARoomate.DataLayer.Entities;
using FindMeARoomate.DataLayer.Repositories;

namespace FindMeARoomate.BusinessLayer
{
    public class ApplicationService
    {
        #region Business Layer
        //Application Business Logic
        //Get All applications
        public List<Application> GetApplications()
        {
            var applicationRepo = new ApplicationRepository();
            var applications = applicationRepo.GetAllApplication();
            return applications;
        }
        //Make an application
        public void MakeApplication()
        {
            Console.WriteLine("Make an Application");
            var application = new Application();
            Console.WriteLine("Enter Announcement ID");
            application.AnnouncementID = int.Parse(Console.ReadLine());

            //Add student
            var applicationRepository = new ApplicationRepository();
            applicationRepository.AddApplication(application);
        }
        //Log in
        //Application Business Logic
        #endregion
    }
}

