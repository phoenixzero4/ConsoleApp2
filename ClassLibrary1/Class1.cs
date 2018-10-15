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
            gloria.setName("gloria");
            gloria.setId(5555);
            StudentDetails brodi = new StudentDetails("brodi", 5150);
            StudentDetails phoenix = new StudentDetails("phoenix", 0000);

            List<StudentDetails> students = new List<StudentDetails> {
               phoenix,gloria,brodi           
            };

            string a = gloria.Login(gloria, students);       
            string b = phoenix.Login(phoenix, students); 
            Assert.AreEqual("Welcome " + gloria.getName(),a);
            Assert.AreEqual("Welcome phoenix",b);
        }
        [Test]
        public void Test2()
        {
            StudentDetails brodi = new StudentDetails("brodi", 8650);
            StudentDetails lael = new StudentDetails("lael", 0000);
            StudentDetails leroy = new StudentDetails("leroy", 2222);
            StudentDetails phoenix = new StudentDetails("phoenix", 1234);
            StudentDetails nullman = new StudentDetails("", 0);
            List<StudentDetails> list = new List<StudentDetails>
            {
                leroy,
                phoenix,
                lael,
                brodi
            };
            List<StudentDetails> list2 = new List<StudentDetails>
            {
                leroy,
                phoenix,
                lael,
                brodi
            };


            // will return list or empty list if a value is null 
            list = StudentDetails.AllUsers(list, list2);
            Assert.AreEqual(list2, list);
            
        }
    }
}
