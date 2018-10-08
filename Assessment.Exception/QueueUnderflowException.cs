using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Exception
{
    public class Custom_QueueUnderflowException: CustomException
    {
        public Custom_QueueUnderflowException():base("Queue is empty")
        {

        }

        public Custom_QueueUnderflowException(string CustomErrorMessage) : base(CustomErrorMessage)
        {

        }
    }
}
