using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class tests
    {
        public string concat(string x, string y)
        {
            string result = x + y;
            return result;
        }
        public string cpy(string x)
        {
            string copy = x;
            return copy;
        }
        public bool testEmpty(string x)
        {
            if (x == "")
                return true;
            return false;
        }
        public bool cmpr(string x, string y)
        {
            if (x == y) return true;
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
                       
        }
    }
}
