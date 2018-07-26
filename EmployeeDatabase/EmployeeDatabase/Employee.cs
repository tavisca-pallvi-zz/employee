using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDatabase
{
    class MyException : Exception
    {
        public MyException(string msg) : base(msg)
        {

        }

    }



    class Employee
    {
        private int _empId;
        private string _empName;
        private string _empQualification;
      

        public string Name {

            get
            {
                return _empName;
            }
            set
            {
                _empName = value;
            }


        }
        public int Id {

            get
            {
                return _empId;
            }
            set
            {
                _empId = value;
            }



        }

        public string qual
        {

            get
            {
                return _empQualification;
            }
            set
            {
                _empQualification = value;
            }



        }


        public int CheckQualification()
        {
            if (_empQualification.Equals("BE") || _empQualification.Equals("BSE") || _empQualification.Equals("BCA"))
            {


                Console.WriteLine("Employee added under IT Department");
            }

           else if (_empQualification.Equals("BCom") || _empQualification.Equals("MCom") || _empQualification.Equals("CA"))


                Console.WriteLine("Employee added under Account Department");
            else
            {

                throw new MyException("Qualification can’t be empty");
                
            }
            return 1;


        }
    }
}
    






    
