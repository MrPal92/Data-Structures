using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Exception
{
    public class CustomException
    {
        private string errorMessage;

        public string ErrorMessage
        {
            get { return errorMessage; }
            set { errorMessage = value; }
        }

        public CustomException(string errorMessage ="Some Error Occurred")
        {
            ErrorMessage = errorMessage;
        }
    }
}
