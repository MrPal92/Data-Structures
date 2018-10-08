using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Exception
{
    public class Custom_QueueOverflowException : CustomException
    {
        public Custom_QueueOverflowException(): base("Queue is Full")
        {

        }

        public Custom_QueueOverflowException( string CustomErrorMessage): base(CustomErrorMessage)
        {
            
        }
    }
}
