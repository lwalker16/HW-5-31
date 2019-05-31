using System;
using System.Collections.Generic;
using System.Text;

namespace Frutees
{
    public class Fruit
    {
        public string _name { set; get; }
        public string _color { set; get; }


        public void FruitDesc(string Fname, string Fcolor)
        {
            _name = Fname;
            _color = Fcolor;
            Console.WriteLine("The color of this fruit is: {0}", Fcolor);
        }

        public class fruits : Fruit
        {
            public string _shape { set; get; }
        }

        public void Eaten(string Fname, string FrEater)
        {
            _name = Fname;
            string _eater = FrEater;
            Console.WriteLine("{0} has been eaten" , FrEater);
        }
        public void Human(string Hname, string FrEater)
        {
            _name = Hname;
            string _eater = FrEater;
            Console.WriteLine("{0} ate {1}", FrEater);
        }
    }
    
   


}
