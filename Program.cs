// See https://aka.ms/new-console-template for more information
using FindMeARoomate.BusinessLayer;
using FindMeARoomate.DataLayer.DatabaseContext;
using FindMeARoomate.DataLayer.Entities;
using System;
using System.Transactions;

Console.WriteLine("Welcome to Find Roommate Application!");
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Menu");
Console.WriteLine("1 - Register");
Console.WriteLine("2 - Get All students");
Console.WriteLine("3 - Log In");
Console.WriteLine("4 - Get My Profile");
Console.WriteLine("5 - Make an announcement");
Console.WriteLine("6 - Make an application");
Console.WriteLine("7 - Approve an application");

int choice = int.Parse(Console.ReadLine());
switch (choice)
{
    case 1:
        {
            //Register
            var studentService = new StudentService();
            studentService.RegisterStudent();
            break;
        }
    case 2:
        {
            //Print all students
            var studentService = new StudentService();
            var students = new List<Student>();
            students = studentService.GetStudents();
            foreach (var s in students)
            {
                Console.WriteLine(s.Name + " " + s.Surname + " " + s.Address + " " + s.Gender);
            }
            break;
        }
    case 3:
        {
            //Get Log in Credentials
            Console.WriteLine("Enter Email");
            var Email = Console.ReadLine();
            Console.WriteLine("Enter Password");
            var Password = Console.ReadLine();
            //Register
            var studentService = new StudentService();
            studentService.LogIn(Email, Password);
            break;
        }

    case 4:
        {
            Console.WriteLine("Enter Email");
            var Email = Console.ReadLine();
            var studentService = new StudentService();
            studentService.GetMyProfile(Email);
            //Get My Profile
            break;
        }


   case 5:
    {
        Console.WriteLine("Enter mail");
        var Email = Console.ReadLine();
        var studentService = new AnnouncementService();
        studentService.AddAnnouncement(Email);
        //Get My Profile
        break;
    }

    case 6:
        {
            Console.WriteLine("Enter title");
            var Title = Console.ReadLine();

            Console.WriteLine("Enter email");
            var Email = Console.ReadLine();

            var applicationService = new ApplicationService();

            applicationService.MakeApplication(Title, Email);
        
            break;
        }

        case 7:
        {
            Console.WriteLine("Enter ID");
            var ApplicationID = int.Parse(Console.ReadLine());

            var applicationService = new ApplicationService();
            applicationService.ApprovedAppliation(ApplicationID);

            Console.WriteLine("Approved application");

            break;
        }
}
Console.WriteLine("--------------------------------------------------");