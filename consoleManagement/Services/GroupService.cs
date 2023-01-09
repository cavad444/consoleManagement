using consoleManagement.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleManagement.Services
{
    internal class GroupService : IGroupService
    {
        private List<Group> _groups { get; set; } = new List<Group>();
        public List<Group> Groups { get { return _groups; } }
        public void CreateGroup(string no, string category, string isOnline)
        {

            //Group group = new Group(no, category, isOnline);
            Group group = new Group()
            {
                No = no,
                Category = category,
                IsOnline = isOnline
            };
            if (isOnline == "true")
            {
                group.Limit = 15;
            }
            else
            {
                group.Limit = 10;
            }
            if (string.IsNullOrEmpty(group.Category) || string.IsNullOrEmpty(group.IsOnline) || string.IsNullOrEmpty(group.No))
            {
                Console.WriteLine("Qrup yaradila bilmedi");
            }
            else {
                Console.WriteLine($"Group {group.No} has created");
                Groups.Add(group);
            }


        }
        public void ShowGroups()
        {
            foreach (Group group in Groups)

                Console.WriteLine(group);
        }

        public void EditGroup(string groupName, string newNameOfGroup)
        {
            if (string.IsNullOrEmpty(groupName) || string.IsNullOrEmpty(newNameOfGroup))
            {
                Console.WriteLine("Qrup adi deyishdirile bilmedi");
            }
            else
            {
                foreach (Group group in Groups)
                {
                    if (groupName == group.No)
                    {
                        Console.WriteLine($"{group.No} qrupunun nomresi {newNameOfGroup} ile evez olundu.");
                        group.No = newNameOfGroup;
                        return;
                    }

                }
                Console.WriteLine($"{groupName} adli qrup yoxdur.");
            }
        }
        public void CreateStudent(string studentName,string studentSurname,string groupNo,string type)
        {
            foreach(Group group in Groups)
            {
                if(groupNo == group.No)
                {
                    Student student = new Student()
                    {
                        FullName = $"{studentName} {studentSurname}",
                        GroupNo = groupNo,
                        Type = type
                    };
                       group.Students.Add(student);
                    return;

                }
            }
            Console.WriteLine($"{groupNo} adli qrup yoxdur.");

        }
        public void ShowStudentsByGroup(string groupName){ 

            foreach(Group group in Groups)
            {
                if(groupName == group.No)
                {
                    foreach(Student student in group.Students)
                    {
                        Console.WriteLine($"Ad Soyad:{student.FullName}, Qrup nomresi:{student.GroupNo}, Telebenin zemanetli olma statusu:{student.Type}");
                    }
                    return;
                }
            }
            Console.WriteLine("Bu adla qrup movcud deyil");
        }
        public void ShowAllStudents()
        {
            foreach(Group group in Groups)
            {
                foreach(Student student in group.Students)
                {
                    Console.WriteLine($"Ad ve soyad: {student.FullName}, Qrup:{student.GroupNo}, Online olma statusu: {group.IsOnline}");
                }
            }
        }
        }
    }

