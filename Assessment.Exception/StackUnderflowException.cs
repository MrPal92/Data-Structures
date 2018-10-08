using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Exception
{
    public class Custom_StackUnderflowException: CustomException
    {
        public Custom_StackUnderflowException(): base("Stack is Empty.")
        {

        }
    }
}
