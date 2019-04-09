using System;
using System.Collections.Generic;
using System.Text;

namespace EmpInfo
{
    public class Employee
    {
        public string employeeName { get; set; }
        public string empId { get; set; }
        public string empMobile { get; set; }
        public string empAddress { get; set; }
        private string _empTweetId;
        public string empTweetId
        {
            get { return _empTweetId; }
            set
            {
                if (value.StartsWith("@"))
                {
                    _empTweetId = value;
                }
                else
                {
                    throw new Exception("Please start Tweet Id with @ sign");
                }
            }
        }
    }
}
