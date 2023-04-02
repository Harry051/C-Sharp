using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members_and_Finalisers__Destructors
{
    internal class Members
    {
        // member - private field
        private string memberName;
        private string jobTitle;
        private int salary;

        // member - public field
        public int age;

        // member - property - exposes job title safely. Properties start with a capital letter
        public string JobTitle
        {
            get
            {
                return this.jobTitle;
            }
            set
            {
                this.jobTitle = value;
            }
        }

        // public member method - can be called from other classes
        public void Introduction(bool isFriend)
        {
            if (isFriend == true)
            {
                Console.WriteLine($"Hi I'm {memberName}, I work as a {jobTitle} and I'm {age} years old");
                SharePrivateInfo();
            }
            else
            {
                Console.WriteLine($"Hi I'm {memberName}, I work as a {jobTitle} and I'm {age} years old");
            }
        }

        private void SharePrivateInfo()
        {
            Console.WriteLine($"My salary is {salary}");
        }

        // member - constructor
        public Members()
        {
            age = 30;
            memberName = "Luca";
            salary = 12000;
            jobTitle = "bus driver";
            Console.WriteLine($"Object created for {memberName}");
        }

        // member - finalizer/destructor  - uses tilde and then is automatically called outside of static void main
        ~Members()
        {
            Console.WriteLine("Members object destroyed");
            Debug.Write("Members object destroyed");
        }
    }
}
