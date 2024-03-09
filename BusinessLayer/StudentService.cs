using FindMeARoomate.DataLayer.Entities;
using FindMeARoomate.DataLayer.Repositories;

namespace FindMeARoomate.BusinessLayer
{
    public class StudentService
    {
        #region Business Layer
        //Student Business Logic
        //Get All students
        public List<Student> GetStudents()
        {
            var studentRepo = new StudentRepository();
            var students = studentRepo.GetAllStudent();
            return students;
        }
        //Register Student
        public void RegisterStudent()
        {
            Console.WriteLine("Register");
            var student = new Student();
            Console.WriteLine("Enter Name");
            student.Name = Console.ReadLine();
            Console.WriteLine("Enter Surname");
            student.Surname = Console.ReadLine();
            Console.WriteLine("Enter Address");
            student.Address = Console.ReadLine();
            Console.WriteLine("Enter Gender");
            student.Gender = Console.ReadLine();
            Console.WriteLine("Enter Email");
            student.Email = Console.ReadLine();
            Console.WriteLine("Enter Password");
            student.Password = Console.ReadLine();
            //Add student
            var studentRepository = new StudentRepository();
            studentRepository.AddStudent(student);
        }
        //Log in
        //Student Business Logic
        #endregion

        public void LogIn(string email, string password)
        {
            var studentRepository = new StudentRepository();

            var student = studentRepository.GetAllStudent()
                         .Where(p => p.Password == password &&
                          p.Email == email)
                          .FirstOrDefault();

            //Check the result
            if (student == null)
            {
                Console.WriteLine("Log in failed");
                throw new Exception("Log in failed");
            }
            else
            {
                Console.WriteLine("Log in Successfull");
            }
        }
        public void GetMyProfile(string email)
        {
            var studentRepository = new StudentRepository();

            var student = studentRepository.GetAllStudent()
                         .Where(p=> p.Email == email)
                          .FirstOrDefault();

            if (student == null)
            {
                Console.WriteLine("User not found");
                throw new Exception("User not found");
            }
            else 
                {

                    Console.WriteLine(student.Name + "         " + student.Surname + "        " + student.Address + "       " + student.Email + "       " + student.Birthday);
                }
            }
        }
        }
    