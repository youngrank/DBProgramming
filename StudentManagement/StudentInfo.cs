using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    [Serializable]
    class StudentInfo
    {
       
        public String name { get; set; }    // 이름
        public String sid { get; set; }     // 학번
        public String gender { get; set; }  // 성별

    }
}
