namespace Assignment
{
    #region p1
    enum WeekDays
    {
        monday,tuesday,wednesday,thursday,friday,saturday,sunday
    }
    #endregion
    #region p3
    enum Season
    {
        Spring, Summer, Autumn, Winter
    }
    #endregion
    #region p4
    [Flags]
    enum Permission
    {
        None = 0,Read = 1,Write = 2,Delete = 4,Execute = 8
    }
    #endregion
    #region p5
    enum Colors
    {
        Red, Green, Blue
    }
    #endregion
    internal class Program
    {
        private static void Main()
        {
            #region p01
            //foreach(WeekDays Day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(Day);

            //}
            #endregion
            #region p02
            //Person[] people = new Person[3] ;
            //people[0] = new Person("hassan", 22);
            //people[1] = new Person("abdo", 29);
            //people[2] = new Person("hassan", 32);

            //foreach(Person person in people)
            //{
            //    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            //}

            #endregion
            #region p03
            //Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
            //string input = Console.ReadLine();
            //Season season = (Season)Enum.Parse(typeof(Season), input,true);

            //if (season == Season.Spring)
            //{
            //    Console.WriteLine("Spring: March to May");
            //}
            //else if (season == Season.Summer)
            //{
            //    Console.WriteLine("Summer: June to August");
            //}
            //else if(season == Season.Autumn)
            //{
            //    Console.WriteLine("Autumn: September to November");
            //}
            //else if(season == Season.Winter)
            //{
            //    Console.WriteLine("Winter: December to February");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid season entered.");
            //}


            //switch (season)
            //{
            //    case Season.Spring:
            //        Console.WriteLine("Spring: March to May");
            //        break;
            //    case Season.Summer:
            //        Console.WriteLine("Summer: June to August");
            //        break;
            //    case Season.Autumn:
            //        Console.WriteLine("Autumn: September to November");
            //        break;
            //    case Season.Winter:
            //        Console.WriteLine("Winter: December to February");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid season entered.");
            //        break;
            //}

            #endregion
            #region p04
            //Permission userPermissions = Permission.None;

            //userPermissions |= Permission.Read;  
            //userPermissions |= Permission.Write;  
            //userPermissions |= Permission.Execute; 
            //Console.WriteLine("Current Permissions: " + userPermissions);

            //bool hasReadPermission = (userPermissions & Permission.Read) == Permission.Read;
            //bool hasDeletePermission = (userPermissions & Permission.Delete) == Permission.Delete;
            //Console.WriteLine("Has Read Permission: " + hasReadPermission);
            //Console.WriteLine("Has Delete Permission: " + hasDeletePermission);

            //userPermissions &= ~Permission.Write;
            //Console.WriteLine("Updated Permissions (after removing Write): " + userPermissions);

            //bool hasWritePermission = (userPermissions & Permission.Write) == Permission.Write;
            //Console.WriteLine("Has Write Permission: " + hasWritePermission);
            #endregion
            #region p05
            //Console.WriteLine("Enter a color:");
            //string input = Console.ReadLine();
            //try 
            //{ 
            //Colors color = (Colors)Enum.Parse(typeof(Colors), input, true);
            //    Console.WriteLine($"{color} is a primary color.");
            //}
            //catch (ArgumentException)
            //{
            //    Console.WriteLine($"{input} is not a primary color.");
            //}
            #endregion
            #region p06
            //Console.WriteLine("Enter the first point (X and Y):");
            //double x1;
            //double.TryParse(Console.ReadLine(), out x1);
            //double y1;
            //double.TryParse(Console.ReadLine(), out y1);
            //Console.WriteLine("Enter the  second point (X and Y):");
            //double x2;
            //double.TryParse(Console.ReadLine(), out x2);
            //double y2;
            //double.TryParse(Console.ReadLine(), out y2);

            //point p1 = new point(x1,y1);
            //point p2 = new point(x2,y2);
            //double distance = Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
            //Console.WriteLine($"The distance between the two points is: {distance}");
            #endregion
            #region p07
            //Person[] persons = new Person[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter details for Person {i + 1}:");

            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();

            //    Console.Write("Age: ");
            //    int age ;
            //    int.TryParse(Console.ReadLine(), out age);

            //    persons[i] = new Person(name, age);
            //}
            //Person oldest = persons[0];
            //foreach (var person in persons)
            //{
            //    if (person.Age > oldest.Age)
            //    {
            //        oldest = person;
            //    }
            //}

            //Console.WriteLine(oldest);
            #endregion

        }
    }
}
