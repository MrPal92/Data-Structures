using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Exception
{
    public class QueueUnderflow: CustomException
    {
        public QueueUnderflow():base("Queue is empty")
        {

        }

        public QueueUnderflow(string CustomErrorMessage) : base(CustomErrorMessage)
        {

        }
    }
}
