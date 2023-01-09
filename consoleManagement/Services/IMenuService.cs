using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleManagement.Services
{
    internal interface IMenuService
    {
        public void CreateGroupMenu();
        public void ShowGroupsMenu();
        public void EditGroupMenu();
        public void ShowStudensByGroupMenu();
        public void ShowAllStudentsMenu();
        public void CreateStudentMenu();

    }
}
