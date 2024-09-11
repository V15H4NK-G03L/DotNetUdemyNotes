using System.ComponentModel;
using System.Text;
using UdemyBiz.Math;

namespace UdemyBiz
{
    class Program
    {
        static void Main(string[] args)
        {
            var John = new Person();
            John.firstname = "John";
            John.lastname = "Smith";
            John.Introduce();

            Calculator calculator = new Calculator();
            var Result = calculator.Add(1, 2);
            Console.WriteLine("The answer is : " + Result);

            int ColorResult = Color.Red + Color.Green + Color.Blue;
            Console.WriteLine("The sum of colors is: " + ColorResult);

            int[] newArray = new int[5] {1, 2, 3, 4, 5};
            Console.WriteLine("The element at 4th position in the array is: " + newArray[3]);

            var flags = new bool[2];
            flags[0] = true;
            Console.WriteLine("The 1st flag is: " + flags[0] + " while the 2nd flag is: " + flags[1]);

            string Intro = string.Format("{0} is my name and {1} is my surname", "Vishank", "Goel");
            Console.WriteLine(Intro);

            string NumList = string.Join("",newArray);
            Console.WriteLine("The concatenated form of numArray is: " + NumList);

            string FilePath = @"C:\New\Folder\File";
            Console.WriteLine("The file path is: " + FilePath);

            var a = 1;
            var b = 1;
            var c = 3;

            if (a > b)
            {
                Console.WriteLine("A is greater than B");
            }
            else if (b > a)
            {
                Console.WriteLine("B is greater than A");
            }
            else
            {
                Console.WriteLine("A is equal to B");
            }

            //Overspeeding overspeeding = new Overspeeding();
            //Console.WriteLine("Enter Your Speed : ");
            //var YourSpeed = Console.ReadLine();
            //int YourSpeedInInt = int.Parse(YourSpeed);

            //Console.WriteLine("Enter the Speed Limit : ");
            //var SpeedLimit = Console.ReadLine();
            //int SpeedLimitInInt = int.Parse(SpeedLimit);
            //overspeeding.SpeedCheck(YourSpeedInInt,SpeedLimitInInt);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("The value of 'i' is : " + i);
            }

            var name = "John Smith";


            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            var j= 0;
            while (j <= 10)
            {
                if(j%2==0)
                    Console.WriteLine("Even number in while loop is: " + j);

                j++;
            }


            //Random Password Generator(RPG)///////////////////////////////////////////////////////

            Console.WriteLine();
            Console.WriteLine("Please enter the desired length of password : ");
            //int passwordLength = Console.Read();
            const int passwordLength = 10;
            var randomPassword = GenerateRandomPassword(passwordLength);
            Console.WriteLine("Your one time use unique password is: " + randomPassword);
            Console.WriteLine("The length of your unique password is: " + randomPassword.Length);
            Console.WriteLine();

            /////////////////////////////////////////////////////////////////////////////////


            var matrix = new int[2, 4]
            {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 }
            };

            var element = matrix[1, 1];
            Console.WriteLine("The element in the 2D array is: " + element);

            var colors = new int[2, 3, 4];

            var array = new int[3][];
            array[0] = new int[2];
            array[1] = new int[3];
            array[2] = new int[4];

            array[0][0] = 1;

            //Methods for Arrays are as follows :
            //Array.IndexOf(arrayName, size);
            //arrayName.Length();
            //Array.Clear(arrayName,startingNumber,endingNumber);
            //Array.Copy(arrayName,newArrayName,newArraySize);
            //Array.Sort(arrayName);
            //Array.Reverse(arrayName);

            var numbers = new List<int>() { 1, 2, 3, 4 };

            //Date and Time usage :
            var dateTime = new DateTime(2024, 1, 1);
            var now = DateTime.Now;
            var Today = DateTime.Today;

            Console.WriteLine("Hour is: " + now.Hour);
            Console.WriteLine("Minute is: " + now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(tomorrow.ToLongDateString());
            Console.WriteLine(tomorrow.ToShortDateString());
            Console.WriteLine(yesterday.ToLongTimeString());
            Console.WriteLine(yesterday.ToShortTimeString());

            //TimeSpan :
            var timespan = new TimeSpan(1, 2, 3);
            Console.WriteLine("Total time in minutes: " + timespan.TotalMinutes);
            Console.WriteLine("Add Time example: " + timespan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Converting to string: " + timespan.ToString());
            Console.WriteLine("Parse : " + TimeSpan.Parse("01:02:03"));

            //Strings :
            var strName = "Hello World";
            var index = strName.IndexOf(' ');
            var firstName = strName.Substring(0, index);
            var lastName = strName.Substring(index + 1);
            Console.WriteLine("First name is: " + firstName);
            Console.WriteLine("Last name is : " + lastName);

            Console.WriteLine(strName.Replace("Hello", "h3110"));

            var builder = new StringBuilder();
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);

            builder.Replace('-', '*')
                    .Remove(0, 10)
                    .Insert(0, new string('+', 10));
            
            
            Console.WriteLine(builder);

            //File.Create(@"C:\Users\user1\Desktop\HACKED.py");
            var fileinfo = new FileInfo(@"C:\Users\user1\Desktop\HACKEDAGAIN.py");
            using (FileStream fileStream = fileinfo.Create())
            {
                //To open and close the filestream so the file can be created and deleted in the same process.
            }
            Console.WriteLine("File created successfully!");
            fileinfo.Delete();
            Console.WriteLine("File deleted successfully!");
            Console.WriteLine("2 Files Created. 1 File deleted.");


        }


        public static string GenerateRandomPassword(int passwordLength)
        {
            var random = new Random();
            var buffer = new char[passwordLength];

            for (var i = 0; i < passwordLength; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));

            var randomPassword = new string(buffer);
            return randomPassword;
        }

    }

    public struct Color
    {
        public static int Red = 1;
        public static int Green = 2;
        public static int Blue = 3;
    }

    //Arrays, Strings and Enums examples pending

}