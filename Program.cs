// See https://aka.ms/new-console-template for more information

// js (import) CS Using
// can also use System.Console
using System;
using System.Collections.Generic;
using day_1.models;


internal class Program
{
  private static void Main(string[] args)
  {
    //Capital Letters everywhere!!!
    //Pascal case (UpperCamelCase) for global and method names 
    //End of every statement must terminate with ';'
    Console.WriteLine("Hello, World!");

    //variable Declarations
    //var, const, T
    //cannot change type after initialized 

    //Implicit
    var firstName = "nik";
    Console.WriteLine(firstName);


    //Explicit (providing type)
    string lastName;
    lastName = "Lyons";
    Console.WriteLine(lastName);

    //Primitives 

    //STRINGS 
    //defined by " "(no more backtick ` or ' for strings)

    // concat
    //string fullName = firstName + " " + lastName;

    //interpolation(${} inside the string)
    string fullName = $" Hello my name is {firstName} {lastName}";

    //multi line string(@)
    string rock = @"
                                                                                                 ______                                                                           
  ________    ________ ______   _____    ___________      _____    _____ ______   _____     _____|\     \        ______  ______      _____        ______  ______   ______   _____  
 /        \  /        \\     \  \    \   \          \    |\    \   \    \\     \  \    \   /     / |     |       \     \|\     \   /      |_      \     \|\     \ |\     \ |     | 
|\         \/         /|\    |  |    |    \    /\    \    \\    \   |    |\    |  |    |  |      |/     /|        |     |\|     | /         \      |     |\|     |\ \     \|     | 
| \            /\____/ | |   |  |    |     |   \_\    |    \\    \  |    | |   |  |    |  |      |\____/ |        |     |/____ / |     /\    \     |     |/____ /  \ \           | 
|  \______/\   \     | | |    \_/   /|     |      ___/      \|    \ |    | |    \_/   /|  |\     \    | /         |     |\     \ |    |  |    \    |     |\     \   \ \____      | 
 \ |      | \   \____|/  |\         \|     |      \  ____    |     \|    | |\         \|  | \     \___|/          |     | |     ||     \/      \   |     | |     |   \|___/     /| 
  \|______|  \   \       | \         \__  /     /\ \/    \  /     /\      \| \         \__|  \     \              |     | |     ||\      /\     \  |     | |     |       /     / | 
           \  \___\       \ \_____/\    \/_____/ |\______| /_____/ /______/|\ \_____/\    \\  \_____\            /_____/|/_____/|| \_____\ \_____\/_____/|/_____/|      /_____/  / 
            \ |   |        \ |    |/___/||     | | |     ||      | |     | | \ |    |/___/| \ |     |            |    |||     | || |     | |     ||    |||     | |      |     | /  
             \|___|         \|____|   | ||_____|/ \|_____||______|/|_____|/   \|____|   | |  \|_____|            |____|/|_____|/  \|_____|\|_____||____|/|_____|/       |_____|/   
                                  |___|/                                            |___|/                                                                                         
";


    //SECTION fun with the console 
    Console.Clear();
    Console.WriteLine(rock);


    //numbers
    //JS (Number) c#(int, double)
    //Math everything stays the same


    //booleans (true and false  !!!!!)
    //no more truthy/ falsey

    // if(fullName != lastName)
    // {
    // System.Console.WriteLine("they are not the same");
    // }


    //Reference 

    //Array(not as useful as they once was)
    //on creation the array is provided a length, it is never longer, never shorter 
    // String[] cats = new String[3]{"HotShot", "Jerry", "Nik"};
    // cats[0] = "Mittens";
    // cats[1] = "Oscar";
    // cats[2] = "Snowball";


    //  List (the array you want)
    // must be instantiated 
    // List<String> cats = new List<String>(){"HotShot", "Jerry", "Nik"};
    // cats.Add("Jon");



    //loops
    //FOR
    // for(int i = 0; i < cats.Count; i++)
    // {
    //   string cat = cats[i];
    //   System.Console.WriteLine(cat);
    // }

    //FOR EACH
    // foreach( string cat in cats)
    // {
    //   Console.WriteLine(cat);
    // }


    //OBJECTS
    //there os a POCO ... don't use it 

    // Dictionaries Key Value pair
    Dictionary<string, int> catAges = new Dictionary<string, int>();
    catAges.Add("wiskers", 9);
    catAges.Add("Hope", 3);
    catAges.Add("Orion", 12);
    catAges.Add("Nike", 10);


    // class

    Dinosaur dino = new Dinosaur("Sarah", "Herbivore", 12);
    dino.Name = "Sarah";
  
  }
}

//