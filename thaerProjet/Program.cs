﻿// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Linq;


Console.WriteLine("Hello, World!");


String firstName = "Thaer";
Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine("First Name:" + firstName);

String lastName = "Abbas";
int age = 32;

Console.ForegroundColor = ConsoleColor.Red;
Console.BackgroundColor = ConsoleColor.Black;

Console.WriteLine("Last Name:" + lastName + "\n" + "Age:" + age);

var currentDate = DateTime.Now;
Console.WriteLine("Curent Date:" + currentDate);

// Declare variables and then initialize to zero.
int num1 = 0;
int num2 = 0;

// Ask the user to type the first number.
Console.WriteLine("Type a number, and then press Enter");
num1 = Convert.ToInt32(Console.ReadLine());

// Ask the user to type the second number.
Console.WriteLine("Type another number, and then press Enter");
num2 = Convert.ToInt32(Console.ReadLine());

if (num1 < num2)
{
    Console.WriteLine("The biggest number :" + num2);
}
else if (num2 == num1)
{
    Console.WriteLine("the numbers are aquals ");
}
else
{
    Console.WriteLine("The biggest number :" + num1);
}

Console.WriteLine("=======================================================================================");

// Declare variables and then initialize to zero.
int num3 = 20;
int num4 = 0;
int count = 0;

// Ask the user to guiss the number.
Console.WriteLine("Type a number to guiss wich number i chosse from (1 to 100) and then press Enter");

do
{
    num4 = Convert.ToInt32(Console.ReadLine());
    count++;
    if (num4 == num3)
    {
        Console.WriteLine("Congratulations, you won after trying" + " " + count + " " + "times ");
    }
    else if (num4 < num3)
    {
        Console.WriteLine("The number was to Small");
    }
    else if (num4 > num3)
    {
        Console.WriteLine("The number was to large");
    }
} while (num4 != num3);

Console.WriteLine("=======================================================================================");

// Ask the user to Write a text.
Console.WriteLine("write a text to save to the file");
String text = Convert.ToString(Console.ReadLine());


string path = @"D:\projet.txt";

// Create a file to write to.
string createText = text + Environment.NewLine;
File.WriteAllText(path, createText);


Console.WriteLine($"your file text saved to the file (projet.txt) inside {path} with SUCCESS");

Console.WriteLine("===========================================================");

Console.WriteLine("type o to open the file to read the text");
// Open the file to read from.
string readText = File.ReadAllText(path);

if (Console.ReadKey().Key == ConsoleKey.O)
{
    Console.WriteLine("\n your text inside the file is:"+" "+readText);

}

Console.WriteLine("============================================================");

Console.WriteLine("type a number to round it like 1.05");
Decimal number = Convert.ToDecimal(Console.ReadLine(), CultureInfo.InvariantCulture);

// Use Math.Ceiling to round up
Decimal roundedNumber = Math.Ceiling(number);
Console.WriteLine("the result :"+ " "+ roundedNumber);


Console.Write("\nPress 'Enter' to contenu...");

while (Console.ReadKey().Key != ConsoleKey.Enter)
{
}


Console.WriteLine("=============================================================================");
    Console.WriteLine("multiplication table program");

for (int i = 1; i <= 10; i++)
{

    for     (int j = 1; j <= 10; j++)
    {
        Console.WriteLine("\t" + $"{ i} * {j} ="+ " "+ i * j + " \t" );
    }
    Console.WriteLine(" ");
}


Console.WriteLine("===========================================================");

Console.Write("\nPress 'Enter' to contenu...");

while (Console.ReadKey().Key != ConsoleKey.Enter)
{
}

List<int> tab1 = new List<int>();

tab1.Add(8);
tab1.Add(10);
tab1.Add(1);
tab1.Add(7);
tab1.Add(9);
tab1.Add(6);
tab1.Add(2);
tab1.Add(3);
tab1.Add(0);
tab1.Add(5);
tab1.Add(4);

Console.WriteLine("the first table");

foreach (int o in tab1)
{
    Console.WriteLine("\t" + o);
}



tab1.Sort();

List<int> tab2 = new List<int>();

tab2.AddRange(tab1);


Console.WriteLine("the second table with order of growth");

foreach (int o in tab2)
{
    Console.WriteLine("\t" + o);
}

Console.WriteLine("=================================================================");
Console.WriteLine("enter one world to see if it is Palindrome or not");

String myString = Convert.ToString(Console.ReadLine());



string first = myString.Substring(0, myString.Length / 2);
char[] arr = myString.ToCharArray();

Array.Reverse(arr);

string temp = new string(arr);
string second = temp.Substring(0, temp.Length / 2);

if (first.Equals(second))
{
    Console.WriteLine($"your world  ({myString})  is Palindrome.");
}
else
{
    Console.WriteLine($"your world ({myString})  is not Palindrome.");
}

Console.WriteLine("=================================================================");

// Declare variables and then initialize to zero.
int numb1 = 0;
int numb2 = 0;


Console.WriteLine("chosse two numbers to see the numbers between the two numbers like (2 -> 8");

// Ask the user to type the first number.
Console.WriteLine("Type a number, and then press Enter");
numb1 = Convert.ToInt32(Console.ReadLine());

// Ask the user to type the second number.
Console.WriteLine("Type another number, and then press Enter");
numb2 = Convert.ToInt32(Console.ReadLine());

for (int i = numb1; i < numb2; i++) {

    if (i == numb1)
    {
        continue;
       
    }

    Console.WriteLine("\t" + i);
}

Console.WriteLine("=================================================================");
Console.WriteLine("Enter numbers withe comma like (1,2,33)");

 String userInput = Convert.ToString(Console.ReadLine());

var userArray = userInput.Split(',').Select(i => int.Parse(i)).ToArray();

List<int> userList = new List<int>();

userList.AddRange(userArray);

userList.Sort();

    foreach (int h in userList)
    {

 

    if (h % 2 == 0)
    {
       
        Console.WriteLine("\t" + "Marital numbers" + "\t" + h);
    }
    else
    {
       Console.WriteLine("\t" + "Odd numbers" + "\t" + h);
    }


}


Console.WriteLine("=================================================================");


Random rd = new Random();


Player player = new Player();
Character character = new Character();

// Ask the user to type the name of your character.
Console.WriteLine("type the name of your character ");
character.name = Convert.ToString(Console.ReadLine());

// Ask the user to type the name of the player.
Console.WriteLine("type the name of your player ");
player.name = Convert.ToString(Console.ReadLine());


character.health = rd.Next(100, 200);
character.strength = rd.Next(100, 200);
character.luck = rd.Next(100, 200);
Console.WriteLine("\t" + "your character :" + $"{character.name} \n"+ 
    "\t health :"+ $"{character.health} \n" + "\t luck :"+ $"{character.luck} \n"
    + "\t strength :"+ $"{character.strength} \n");


player.health = rd.Next(100, 200);
player.strength = rd.Next(100, 200);
player.luck = rd.Next(100, 200);
Console.WriteLine("\t" + "the player :" + $"{player.name} \n" +
    "\t health :" + $"{player.health} \n" + "\t luck :" + $"{player.luck} \n"
    + "\t strength :" + $"{player.strength} \n");

    

Console.Write("\nPress 'E' to exit the process...");

while (Console.ReadKey().Key != ConsoleKey.E )
{
}

