using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class StudentDetails
    {
        public StudentDetails(){}

        public int Id;
        public string Name;

        public StudentDetails(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public void setId(int id)
        {
            Id = id;
        }
        public int getId()
        {
            return Id;
        }

        public void setName(string x)
        {
            Name = x;
        }
        public string getName()
        {
            return Name;
        }
  
    public string Login(StudentDetails x, List<StudentDetails> y)
    {
        for (int i = 0; i < y.Count; i++)
        {
                Console.WriteLine(x.getName() + " " + x.getId());
            if (x.getName() == y[i].getName() && x.getId() == y[i].getId())
                return "Welcome " + x.getName();
        }
        return "Incorrect Login Credentials";
    }

    public static List<StudentDetails> AllUsers(List<StudentDetails> x, List<StudentDetails> y)
    {
            List<StudentDetails> empty = new List<StudentDetails>();
       
        for (int i = 0; i < x.Count; i++)
        {
             if (x[i].getName() == "" || x[i].getName() == null)
             {
                    Console.WriteLine("The list contains an empty slot");
                    return empty;
             }
             if (x[i].getName() != y[i].getName())
                return empty;
        }
        return x; ;
    }        

        static void Main(string[] args)
        {
        
        }
    }

}