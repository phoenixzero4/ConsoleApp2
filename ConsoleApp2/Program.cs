using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class tests
    {
      
        public class StudentDetails
        {
            public int ID;
            public string Name;

            public StudentDetails(string name, int id)
            {
                Name = name;
                ID = id;
            }
                    
            public void setId(int id)
            {
                ID = id;
            }
            public int getId()
            {
                return ID; 
            }
                        
            public void setName(string x)
            {
                Name = x;
            }  
            public string getName()
            {
                return Name(); 
            }
                
            
        }
        [TestFixture]
        public class Program
        {
            public string Login()
            {

            }
        }
    }
        /* public string Concatenation(string a, string b)
        {
            return a + b;
        }
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
    }*/

}