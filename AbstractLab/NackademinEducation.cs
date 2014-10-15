using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractLab
{
    class NackademinEducation : IEducation
    {

        public int NumberOfStudents
        {
            get
            {
                return 40;
            }
            set
            {
                NumberOfStudents = 40;
            }
        }
    }
}
