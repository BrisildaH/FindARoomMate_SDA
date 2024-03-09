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
        public void MakeApplication(string title, string email)
        {
            var application = new Application();
            var announcementRepository = new AnnouncementRepository();

            Console.WriteLine("Make an Application");

            application.Status = "new";
            application.ApplicationDate = DateTime.Now;
            application.IsActive = true;

            var studentRepository = new StudentRepository();

            Console.WriteLine("Title of announcement");
            var announcement1 = announcementRepository.GetAllAnnouncement()
                                    .Where(p => p.Title == title)
                                     .FirstOrDefault();


            if (announcement1 == null)
            {
                Console.WriteLine("Announcement doesn't exist");
                throw new Exception("Announcement doesn't exist");
            }
            else
            {
                application.AnnouncementID = announcement1.ID;
            }

            var student = studentRepository.GetAllStudent()
                               .Where(p => p.Email == email)
                                .FirstOrDefault();

            if (student == null)
            {
                Console.WriteLine("Application not found");
                throw new Exception("Application not found");
            }

            else
            {
                application.StudentID = student.Id;
            }

            //Add student
            var applicationRepository = new ApplicationRepository();
            applicationRepository.AddApplication(application);

        }

        //Application approved


        //Log in
        //Application Business Logic
        #endregion

        public void ApprovedAppliation(int applicationID)
        {

            var applicationRepository = new ApplicationRepository();

            var application = applicationRepository.GetAllApplication()
                                   .Where(p => p.ID == applicationID)
                                    .FirstOrDefault();

            if (application == null)
            {
                Console.WriteLine("Application not found");
            }

            else
            {
                application.Status= "Approved";
                applicationRepository.UpdateApplication(application);
            }

        }
    }
}
/*
Task Crate Service Make an application
Parameters(titullin e announcement, emailin e userit)
titullin e announcement => application.AnnouncementID
emailin e userit => application.ApplicantID*/

/*
Task Approvo Application
Parameter Application ID
Get Applicaiton
Status New = Approved
Repositoy.Update()*/