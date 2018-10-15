using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program;
using NUnit.Framework;


namespace ClassLibrary1
{
           
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Test()
        {

            StudentDetails gloria = new StudentDetails();
            StudentDetails phoenix = new StudentDetails();
            gloria.setName("gloria");
            gloria.setId(5555);
            
            List<StudentDetails> students = new List<StudentDetails> {
               new StudentDetails("brodi", 5150),
               gloria,
            };

            string a = gloria.Login(gloria, students);
            Console.WriteLine(a);

            string b = phoenix.Login(phoenix, students); 
           // Console.WriteLine(gloria.Login(gloria, students));
            Assert.AreEqual("Welcome " + gloria.getName(),a);
            Assert.AreEqual("Incorrect Login Credentials", b);       
         
        }
    }
}
