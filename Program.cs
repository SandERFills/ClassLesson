using System;

namespace TestClass
{
   public class Human {
        
        private string Name;
        public string NameProp
        {
            get { return Name; }
            set { Name = value; }
        }
        private string SecondName;
        public string SecondNameProp
        {
            get { return SecondName; }
            set { SecondName = value; }
        }
        
            }
            public class Student : Human {
              public  Student(string name,string secondname){
                    NameProp=name;
                    SecondNameProp=secondname;
                }
            }
    class Program
    {
        static void Main(string[] args)
        {
            Human Student =new Student("Vlad","Babich");
           
            System.Console.WriteLine(Student.NameProp+" "+Student.SecondNameProp);
            
        }
    }
}
