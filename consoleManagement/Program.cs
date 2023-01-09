using consoleManagement.Services;

Console.WriteLine("1.Teze qrup");
Console.WriteLine("2.Qruplari goster");
Console.WriteLine("3.Qrupun adini deyish");
Console.WriteLine("4.Telebeleri qrupun adina gore goster");
Console.WriteLine("5.Butun telebeleri goster");
Console.WriteLine("6.Yeni telebe yarat");
Console.WriteLine("0.Proqrami sonlandir");
GroupService groupService = new();
MenuService menuService = new();
int decision = Convert.ToInt32(Console.ReadLine());
while (decision != 0)
{
    if (decision == 1)
    {
        menuService.CreateGroupMenu();

    }
    else if (decision == 2)
    {
        menuService.ShowGroupsMenu();
    }else if(decision == 3)
    {
        menuService.EditGroupMenu();
    }else if(decision == 4)
    {
        menuService.ShowStudensByGroupMenu();
    }else if(decision == 5)
    {
        menuService.ShowAllStudentsMenu();
    }else if(decision == 6)
    {
        menuService.CreateStudentMenu();

    }else if(decision == 0)
    {
        Console.WriteLine("Proqramdan cixdiniz");

    }
    else
    {
        Console.WriteLine("Yanlish secim etdiniz. Zehmet olmasa yuxaridaki secimlerden birini edin");
    }
    Console.WriteLine("Yuxaridaki sechimlerden birini edin.");
    decision = Convert.ToInt32(Console.ReadLine());
}
