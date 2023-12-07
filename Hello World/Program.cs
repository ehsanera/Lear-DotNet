using System;
using System.Collections.Generic;
using Hello_World;

var users = new List<User>
{
    new()
    {
        Id = 1,
        Name = "mohammad javad"
    }
};

start:
{
    Console.Clear();
    Console.WriteLine("############# Menu #########");
    Console.WriteLine("1- Add");
    Console.WriteLine("2- List");
    Console.WriteLine("3- Update");
    Console.WriteLine("4- Delete");
    Console.WriteLine("5- User Count");
    Console.WriteLine("0- Exit");
    Console.Write("Please enter your choice: ");

    var input = Console.ReadLine();

    if (input != null)
    {
        Console.Clear();

        var selectedMenu = int.Parse(input);

        switch (selectedMenu)
        {
            case 1:
            {
                Console.Write("Give Me Name: ");
                var name = Console.ReadLine();
                if (name != null)
                {
                    users.Add(new User { Id = users.Count + 1, Name = name });
                }

                Console.WriteLine($"Your name added to list");
                break;
            }
            case 2:
                foreach (var user in users)
                {
                    Console.WriteLine("User Id: " + user.Id);
                    Console.WriteLine($"User Name: {user.Name}");
                    Console.WriteLine("-------------------------");
                }

                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            case 0:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Out Of Range");
                break;
        }
    }
}

Console.WriteLine("Please press enter fot return to main manu");
Console.ReadLine();
goto start;