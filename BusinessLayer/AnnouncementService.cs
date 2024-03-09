using FindMeARoomate.DataLayer.Entities;
using FindMeARoomate.DataLayer.Repositories;

namespace FindMeARoomate.BusinessLayer
{
    public class AnnouncementService
    {
        public void AddAnnouncement(string email)
        {
            Console.WriteLine("Make an Announcement");
            var announcement = new Announcement();

            Console.WriteLine("Enter Title");
            announcement.Title = Console.ReadLine();

            Console.WriteLine("Enter Description");
            announcement.Description = Console.ReadLine();

            announcement.IsActive = true;

            announcement.PublishedDate = DateTime.Now;

            //Step 1 Inject Student repository
            var studentRepository = new StudentRepository();

            //Step2 check students by email
            var student = studentRepository.GetAllStudent()
                                    .Where(p => p.Email == email)
                                     .FirstOrDefault();
            //Check if result is null
            //If null throw error "Student does not exist"
            if (student == null)
            {
                Console.WriteLine("User not found");
                throw new Exception("User not found");
            }
            else
            {
                //IF not null Assign StudentID value to announcement
                announcement.StudentID = student.Id;
            }
            //Add Announcement
            var announcementRepository = new AnnouncementRepository();
            announcementRepository.AddAnnouncement(announcement);
        }
    }
}