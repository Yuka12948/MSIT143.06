using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_MSIT143_06
{
    struct MyBase
    {
        public string name;
        public int chinese;
        public int english;
        public int math;
    }

    public struct Student
    {
        public string Name { get; set; }
        public int Cht { get; set; }
        public int Eng { get; set; }
        public int Math { get; set; }

        public Student (string StuName,int ChtG, int EngG, int MathG)
        {
            Name = StuName;
            Cht = ChtG;
            Eng = EngG;
            Math = MathG;
        }
    }
}
