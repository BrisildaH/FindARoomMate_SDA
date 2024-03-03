using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMeARoomate.DataLayer.Entities
{
    public class DormitoryStudent
    {

        [Key]
        public int ID { get; set; }
        [ForeignKey("Student")]
        public int StudentID { get; set; }
        public Student Student { get; set; } //here name of object match with foreign key annotation name
        [ForeignKey("Dormitory")]
        public int DormitoryID { get; set; }
        public Dormitory Dormitory { get; set; }
    }
}
