
using System;
namespace NCClabs{
public class classandobject{
    //constructor
    public classandobject()
{
    
}
public classandobject(int i)
{
    Console.WriteLine(i+"value");
}
public classandobject(int i,string s)
{
}
public classandobject(string s, int i)
{
    
}
        //variables
        private int i = 10;
        private string s = "";
        //properties
        public string SProp {get;set;}
        public int I { get => i; set => i = value; }
        public string S { get => s; set => s = value; }
        public string Fname { get => fname; set => fname = value; }

        private string fname;

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}