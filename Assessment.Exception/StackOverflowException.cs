using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Exception
{
    public class Custom_StackOverflowException : CustomException
    {
        public Custom_StackOverflowException(): base("Stack is Full.")
        {

        }
    }
}
