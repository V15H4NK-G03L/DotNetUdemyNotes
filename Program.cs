using System.ComponentModel;
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


            //Random password Generator
            var random = new Random();
            const int passwordLength = 10;
            var buffer = new char[passwordLength];

            for(var i=0; i<passwordLength; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));

            var randomPassword = new string(buffer);

            Console.WriteLine("Your one time use unique password is: " + randomPassword);


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