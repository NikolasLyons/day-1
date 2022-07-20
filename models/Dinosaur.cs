using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace day_1.models
{
    // access modifier (Public, Internal, Protected, Private)
    public class Dinosaur
    {
        //Members (fields**, properties, methods)
//field
        private string _name;
//property
    public string Name { get; set; }
    public string Diet { get; set; }
    public int Age { get; set; }
        // public string Name
        // {
        //     get{
        //         return _name;
        //     }
        //     set{
        //         _name = value.ToUpper();
        //     }
        // }

        //ChangeName
        //Method access modifier return type, name, parameters(signature)
        //NOTE void means no return
        public void  ChangeName(string name)
        {
            //some business logic here
            Name = name;
        }

        public string Speak()
        {
            if(Diet == "Herbivore"){

            return "RRRRRrrrrrRrrrr";
            }else if (Diet == "Carnivore"){
                return "RRRRRRAAAAWWWWW";
            }
            return "Sup Dude";
        }


        //how is this a constructor
        // -public
        // -no return type
        // -name is same as class

        public Dinosaur(string name, string diet, int age)
        {
            Name = name;
            Diet = diet;
            Age = age;

        }
        
    }
}