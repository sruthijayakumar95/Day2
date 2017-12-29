using Day2B.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day2B.ViewModel
{
    public class StudSubj
    {
        Student studObj = new Student();
        Subject subObj = new Subject();
        public int s_id { get=>studObj.Stud_Id; set { studObj.Stud_Id = value; } }
        public string name { get => studObj.Stud_Name; set { studObj.Stud_Name = value; } }
        public string sub_id { get => subObj.Sub_Id; set { subObj.Sub_Id = value; } }
        public string sub_name { get => subObj.Sub_Name; set { subObj.Sub_Name = value; } }
    }
}