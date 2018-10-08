using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Exception
{
    public class QueueOverflow : CustomException
    {
        public QueueOverflow(): base("Queue is Full")
        {

        }

        public QueueOverflow( string CustomErrorMessage): base(CustomErrorMessage)
        {
            
        }
    }
}
