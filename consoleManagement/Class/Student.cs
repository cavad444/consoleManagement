using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleManagement.Class
{
    internal class Student
    {
        private string _fullName;
        private string _groupNo;
        private string _type;
        
        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                if (value.Length > 30 || string.IsNullOrEmpty(value) || value.Length<8)
                {
                    Console.WriteLine("Telebenin adi ve soyadinin uzunlugu 8-30 intervalinda olmalidir");
                }
                else
                {
                    _fullName = value;
                }
            }
        }
        public string GroupNo { 
            get {
                return _groupNo;
            } 
            set
            {
                if(value.Length>7 || string.IsNullOrEmpty(value) || value.Length<3)
                {
                    Console.WriteLine("Qrupun adinin uzunlugu 3-7 intervalinda olmalidi ");
                }
                else {
                    _groupNo = value;
                }
            } 
        }
        public string Type { 
            get {
                return _type;
            }
            set
            {
                if(value == "zemanetli" || value == "zemanetsiz") {
                    _type = value;
                }
                else
                {
                    Console.WriteLine("zehmet olmasa qrup tipine bu  deyerlerden birini daxil edin: zemanetli - zemanetsiz ");
                }

            } 
        }
    }
}
