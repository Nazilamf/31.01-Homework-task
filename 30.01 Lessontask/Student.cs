using System;
using System.Collections.Generic;
using System.Text;

namespace _30._01_Lessontask
{
    internal class Student
    {

        //task1

        public string FullName;
        private byte _age=15;





        public byte Age
        {
            set
            {
                if (value>=15)
                 _age=value;
            }

            get
            {
               return _age; 
            }
        }
    }
}
