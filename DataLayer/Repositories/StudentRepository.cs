﻿using FindMeARoomate.DataLayer.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FindMeARoomate.DataLayer.Entities;

namespace FindMeARoomate.DataLayer.Repositories
{
    public class StudentRepository
    {
        public void AddStudent(Student student)
        { // DbContext Add Method
            var dbContext = new FindMeARoomateContext();
            dbContext.Students.Add(student);
            dbContext.SaveChanges();
        }
        // Get All Student
        public List<Student> GetAllStudent()
        {
            var context = new FindMeARoomateContext();
            var students = context.Students.ToList();
          
            return students;
        }
        // Get By ID
        public Student FindByID(int id)
        {
            try
            {
                var dbContext = new FindMeARoomateContext();
                var student = dbContext.Students.Where(p => p.Id == id)
                    .FirstOrDefault();
                return student;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        //Update
        //Remove
        public void DeleteStudent(Student student)
        {
            try
            {
                var dbContext = new FindMeARoomateContext();
                dbContext.Students.Remove(student);
                dbContext.SaveChanges();
                Console.WriteLine("Student removed");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message.ToString());
                throw ex;
            }
        }
        public void UpdateStudent(Student student)
        {
            try
            {
                var dbContext = new FindMeARoomateContext();
                dbContext.Students.Update(student);
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