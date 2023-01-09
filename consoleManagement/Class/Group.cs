using consoleManagement.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleManagement.Class
{
    internal class Group
    {
        private string _no;
        private string _category;
        private string _isOnline;
        private int _limit;

        public string No {

            get
            {
                return _no;
            }
            set
            {
                if (value.Length > 7 || string.IsNullOrEmpty(value) || value.Length < 3)
                {
                    Console.WriteLine("Qrupun adinin uzunlugu 3-7 intervalinda olmalidi ");
                }
                else
                {
                    _no = value;
                }
            }
        }
        public string Category { 
            get
            { 
                return _category; 
            }
            set 
            {
             foreach(var item in Enum.GetNames(typeof(GroupCategory)))
                {
                    if (value == item)
                    {
                        _category = value;
                        return;
                    }
                    else if (string.IsNullOrEmpty(item.ToString()))
                    {
                        Console.WriteLine("Zehmet olmasa input-u bosh saxlamayin");
                    }
                    
                }
                Console.WriteLine("Zehmet olmasa buradaki sechimlerden birini edin:Proqramlasdirma, NeftQaz ,Kimya,InformasiyaTehlukesizliyi ");
            }
        }
        public string IsOnline {
            get
            { 
                return _isOnline;
            }
            set {
                if(value == "true" || value == "false")
                {
                    _isOnline = value;
                }
                else
                {
                    Console.WriteLine("Zehmet olmasa bu deyerlerden birini daxil edin: true - false");
                }
            }
        }
        public int Limit { get { return _limit; } set { _limit = value; } }
        //public Student[] Students { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();

        //public Group(string no, string category, bool isOnline)
        //{
        //    _no = no;
        //    _category = category;
        //    _isOnline = isOnline;
        //}
        public override string ToString()
        {
            //telebe sayi: { Students.Length}
            return $"qrup no:{No}, qrup kategoriyasi {Category},";
        }
    }
}
