using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpamTask02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 2.1
            Console.WriteLine("Task 2.1"+ Environment.NewLine);
            Round test1 = new Round(); // Creating of empty object and calling the base constractor
            test1.X = -212.0; //demonstration of property field _x
            
            Console.WriteLine($"The round has been created {test1.X} {test1.Y} {test1.Radius}"); //demostration of all fileds property, while they're private in class
            Console.WriteLine($"Property of Round Class for Square {test1.Square}" + Environment.NewLine + $" And Length of circle is {test1.LengthOfRing}");

            Console.WriteLine("Now it's your turn to have fun with a Round" + Environment.NewLine +
                "First type of constractor is Round(double,double,double)");
            double enter1, enter2, enter3;
            Console.Write("X = ");
            #region Big code exception safety
            if (double.TryParse(Console.ReadLine(), out enter1))
            {

            }
            else
            {
                Console.WriteLine("Incorrect input" + Environment.NewLine);
            }
            Console.Write("Y = ");
            if (double.TryParse(Console.ReadLine(), out enter2))
            {

            }
            else
            {
                Console.WriteLine("Incorrect input" + Environment.NewLine);
            }
            Console.Write("Radius = ");
            if (double.TryParse(Console.ReadLine(), out enter3))
            {

            }
            else
            {
                Console.WriteLine("Incorrect input" + Environment.NewLine);
            }
            #endregion
            Round test2 = new Round(enter1,enter2,enter3);
            Console.WriteLine($"The round has been created {test1.X} {test1.Y} {test1.Radius}" +  Environment.NewLine);
            Console.WriteLine($"Property of Round Class for Square {test1.Square}" + Environment.NewLine + $" And Length of circle is {test1.LengthOfRing}");
            Console.WriteLine("You can also switch change some parameters if you want to.");


            #region Code Exception safety 2   
            Console.Write("X = ");
            if (double.TryParse(Console.ReadLine(), out enter1))
            {
                test2.X =enter1;
            }
            else
            {
                Console.WriteLine("Incorrect input" + Environment.NewLine);
            }
            Console.Write("Y = ");
            if (double.TryParse(Console.ReadLine(), out enter2))
            {
                test2.Y =enter2;
            }
            else
            {
                Console.WriteLine("Incorrect input" + Environment.NewLine);
            }
            Console.Write("Radius = ");
            if (double.TryParse(Console.ReadLine(), out enter3))
            {
                test2.Radius =enter3;
            }
            else
            {
                Console.WriteLine("Incorrect input" + Environment.NewLine);
            }
            #endregion
            Round test3 = new Round(enter1,enter2); // x and y counstructor
            Round test4 = new Round(enter3);// radius constructor
            Round test5 = new Round(test1); //class constructor

            Console.WriteLine("And of course we have operators oevrrideda ass ++ added +1 to radius and -- decreasing it on 1 as well");
            test1++;   test2++;     test3++;       test4++;         test5++;
            Console.WriteLine($"{test1.Radius} {test2.Radius} {test3.Radius} {test4.Radius} {test5.Radius}" + Environment.NewLine);
            test1--;    test2--;      test3--;       test4--;       test5--;
            Console.WriteLine($"{test1.Radius} {test2.Radius} {test3.Radius} {test4.Radius} {test5.Radius}" + Environment.NewLine);
            #endregion

            #region Task 2.2
            Console.WriteLine("Task 2.2"+ Environment.NewLine);
            Triangle Hi = new Triangle();
            Console.WriteLine("Propertys {0} {1} {2} Square {3} Perimter {4}",Hi.A, Hi.B, Hi.C, Hi.Square,Hi.Perimetr + Environment.NewLine);
            Console.Write("Side a = ");
            #region big code for safety input
            if (double.TryParse(Console.ReadLine(), out enter1))
            {

            }
            else
            {
                Console.WriteLine("Incorrect input" + Environment.NewLine);
            }
            Console.Write("Side b = ");
            if (double.TryParse(Console.ReadLine(), out enter2))
            {

            }
            else
            {
                Console.WriteLine("Incorrect input" + Environment.NewLine);
            }
            Console.Write("Side c = ");
            if (double.TryParse(Console.ReadLine(), out enter3))
            {

            }
            else
            {
                Console.WriteLine("Incorrect input" + Environment.NewLine);
            }
            #endregion
            Triangle Hi2 = new Triangle(enter1,enter2,enter3);
            Console.WriteLine("Propertys {0} {1} {2} Square {3} Perimter {4}", Hi.A, Hi.B, Hi.C, Hi.Square, Hi.Perimetr + Environment.NewLine);
            #endregion

            #region Task 2.3
            Console.WriteLine("Task 2.3" + Environment.NewLine);
            #region Input from file and object creating
            List<User> Users = new List<User>();
            using (StreamReader sr = new StreamReader("input_2_3.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string [] tmp = line.Split(' ');
                    User keeper = new User(tmp[0], tmp[1], tmp[2], 
                        new DateTime(int.Parse(tmp[3]), int.Parse(tmp[4]), int.Parse(tmp[5]) ) );
                    Users.Add(keeper);


                }
            }
            #endregion
            foreach (User item in Users)
            {
                Console.WriteLine("{0}", item.ToString() + Environment.NewLine);
            }
            User keepOne = new User("Rivian","Geralt","Vesemirovich", new DateTime(1237,2,7));
            User keepTwo = new User("Zhidkovksy", "Evgeniy", "ChortEgoZnaet", new DateTime(1989, 2, 3));
            Console.WriteLine("Age of {0}{1}{2} is {3}" + Environment.NewLine +
                "Age of {4}{5}{6} is {7}", keepOne.Name, keepOne.Surname, keepOne.Otch,keepOne.Age, keepTwo.Name, keepTwo.Surname, keepTwo.Otch, keepTwo.Age);
            Users.Add(keepOne);
            Users.Add(keepTwo);
            #endregion

            #region Task 2.4
            char[] sr1 = new char[] { 'F', 'i', 'r', 's', 't', ' ', 's', 't', 'r', 'i', 'n', 'g', ' ', 't', 'o', ' ', 'w', 'r', 'i', 't','e'};
            char[] sr2 = new char[] { 'O', 'n', 'e', ' ', 'm', 'o', 'r', 'e', };
            ReallyMyString testStr1 = new ReallyMyString(sr1);
            ReallyMyString testStr2 = new ReallyMyString(sr2);
            Console.WriteLine(testStr1.ToString());
            Console.Write("Concatenation: "+Environment.NewLine);
            ReallyMyString testStr3 = testStr1 + testStr2;
            Console.WriteLine(testStr3.ToString());
            

            Console.WriteLine("Search of a symbol in the first string: {0}", testStr3.FindSymbol('e'));
            Console.WriteLine("Search of a symbol in the second one: {0}", testStr3.FindSymbol('a'));
            Console.WriteLine("Comparing two strings (testStr1 == testStr2): {0}", testStr1 == testStr2);
            Console.WriteLine("Comparing two strings (testStr1 == testStr3): {0}", testStr1 == testStr2);
            Console.WriteLine("Comparing two strings (testStr1 != testStr2): {0}", testStr1 != testStr2);
            Console.WriteLine("Comparing two strings (testStr1 != testStr3): {0}", testStr1 != testStr2);
            Console.WriteLine("Конвертация массива в объект: {0}", ((ReallyMyString)sr1).GetType());
            Console.WriteLine("Конвертация объекта строки в массив символов", ((char[])testStr1).GetType());
            Console.WriteLine("index instrument a[2] = {0}", testStr1[2]);
            testStr1[1] = '0';
            Console.WriteLine("Replace second symbol for Zero, a[1] = {0}", testStr1[1]);
            Console.WriteLine(testStr1+Environment.NewLine);

            #endregion

            #region Task 2.5
            

            Employee employee = new Employee("Zhestkiy", "Vitek", "Yur'evich", new DateTime(1991, 2, 1), 8, "Pogrammist");
            Console.WriteLine(employee.ToString()+Environment.NewLine);
            List<Employee> slaves = new List<Employee>();
            slaves.Add(employee);
            foreach (Employee item in slaves)
            {
                Console.WriteLine(item.ToString()+Environment.NewLine);
            }
            #endregion

            #region Taskk 2.6
            Ring figure = new Ring(6,2,5,6);
            Ring figure2 = new Ring(figure);
            Console.WriteLine("Square of inner radius circle {0}"+ Environment.NewLine+
                "Square of ring {1}" + Environment.NewLine +
                "Length of inner radius circle {3}",figure.Square, figure.RingSquare, figure.LengthOfRing);
            #endregion
            Console.ReadLine();
        }
    }
}
