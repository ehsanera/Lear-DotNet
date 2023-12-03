using Hello_World;

var users = new List<User>();

Console.WriteLine("############# Menu #########");
Console.WriteLine("1- Add");
Console.WriteLine("2- List");
Console.WriteLine("3- Update");
Console.WriteLine("4- Delete");
Console.WriteLine("0- Exit");
Console.Write("Please enter your choice: ");

var input = Console.ReadLine();

if (input != null)
{
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

            Console.WriteLine(string.Join("count:", users.Count));
            var list = string.Join(", ", users);
            Console.WriteLine(list);

            break;
        }
        case 2:
            break;
        case 3:
            break;
        case 4:
            break;
        case 0:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Out Of Range");
            break;
    }
}