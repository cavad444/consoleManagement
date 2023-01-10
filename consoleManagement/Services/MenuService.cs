using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleManagement.Services
{
    internal class MenuService:IMenuService
    {
        GroupService groupService = new GroupService();
        public void CreateGroupMenu()
        {
            Console.WriteLine("Qrup nomresi daxil edin!");
            string no = Console.ReadLine();
            Console.WriteLine("Qrup novunu daxil edin: Proqramlasdirma,NeftQaz,Kimya,InformasiyaTehlukesizliyi");
            string category = Console.ReadLine();
            Console.WriteLine("Qrup online olub-olmama statususunu daxil edin(true ve ya false)");
            string isOnline = Console.ReadLine();
            groupService.CreateGroup(no, category, isOnline);
        }
        public void ShowGroupsMenu()
        {
            groupService.ShowGroups();
        }
        public void EditGroupMenu()
        {
            Console.WriteLine("Deyismek istediyiniz qrupun adini daxil edin");
            string groupName = Console.ReadLine();
            Console.WriteLine("Qrupun yeni adini daxil edin");
            string newNameOfGroup = Console.ReadLine();
            groupService.EditGroup(groupName, newNameOfGroup);
        }
        public void ShowStudensByGroupMenu()
        {
            Console.WriteLine("Telebelerini gostermek istediyiniz qrup adini daxil edin.");
            string groupName = Console.ReadLine();
            groupService.ShowStudentsByGroup(groupName);
        }
        public void ShowAllStudentsMenu()
        {
            groupService.ShowAllStudents();

        }
        public void CreateStudentMenu()
        {
            Console.WriteLine("Telebenin adini ve soyadini daxil edin");
            string fullName = Console.ReadLine();
            Console.WriteLine("Qrup nomresini daxil edin");
            string groupNo = Console.ReadLine();
            Console.WriteLine("Telebenin zemanetli olub olmama tipini daxil edin (zemanetli ve ya zemanetsiz sozlerinden birini daxil edin.).");
            string type = Console.ReadLine();
            groupService.CreateStudent(fullName, groupNo, type);
        }
    }
}
