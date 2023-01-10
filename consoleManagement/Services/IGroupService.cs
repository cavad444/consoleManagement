using consoleManagement.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleManagement.Services
{
    internal interface IGroupService
    {
        public List<Group> Groups { get; }
        public void CreateGroup(string no, string category, string isOnline);
        public void ShowGroups();
        public void EditGroup(string groupName,string newNameOfGroup);
        public void CreateStudent(string fullName,string groupNo,string type);
        public void ShowStudentsByGroup(string groupName);
        public void ShowAllStudents();
    }
}
