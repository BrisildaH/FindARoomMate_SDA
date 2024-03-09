using FindMeARoomate.DataLayer.DatabaseContext;
using FindMeARoomate.DataLayer.Entities;

namespace FindMeARoomate.DataLayer.Repositories
{
    public class AnnouncementRepository
    {
        public void AddAnnouncement(Announcement announcement)
        { // DbContext Add Method
            var dbContext = new FindMeARoomateContext();
            dbContext.Announcements.Add(announcement);
            dbContext.SaveChanges();
        }
        // Get All Student
        public List<Announcement> GetAllAnnouncement()
        {
            var context = new FindMeARoomateContext();
            var announcements = context.Announcements.ToList();

            return announcements;
        }
        // Get By ID
        public Announcement FindByID(int id)
        {
            try
            {
                var dbContext = new FindMeARoomateContext();
                var announcement = dbContext.Announcements.Where(p => p.ID == id)
                    .FirstOrDefault();
                return announcement;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        //Update
        //Remove
        public void DeleteAnnouncement(Announcement announcement)
        {
            try
            {
                var dbContext = new FindMeARoomateContext();
                dbContext.Announcements.Remove(announcement);
                dbContext.SaveChanges();
                Console.WriteLine("Announcement removed");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message.ToString());
                throw ex;
            }
        }
        public void UpdateAnnouncement(Announcement announcement)
        {
            try
            {
                var dbContext = new FindMeARoomateContext();
                dbContext.Announcements.Update(announcement);
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
