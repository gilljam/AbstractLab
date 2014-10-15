using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractLab
{
    public class JensenEducation : IEducation
    {
        public int NumberOfStudents
        {
            get
            {
                return 50;
            }
            set
            {
                NumberOfStudents = 50;
            }
        }
    }
}
