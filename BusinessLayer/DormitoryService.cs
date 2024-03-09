using FindMeARoomate.DataLayer.Entities;
using FindMeARoomate.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMeARoomate.BusinessLayer
{
    public class DormitoryService
    {
        public List<Dormitory> GetDormitories()
        {
            var dormitoryRepo = new DormitoryRepository();
            var dormitories = dormitoryRepo.GetAllDormitory();
            return dormitories;
        }
        
    }
}
