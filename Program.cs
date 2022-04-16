using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace ICustomDeveloper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Serialize:");
            Example.CustomSerilizer();

            Console.WriteLine("=================");
            Console.WriteLine("");

            Console.WriteLine("Deserialize: ");
            Employee.Informs();
           
        }

       
    }



    #region Deserialize

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsManager { get; set; }
        public DateTime JoinedDate { get; set; }
        public IList<string> Titles { get; set; }

        public static void Informs()
        {
            string json = @"{
                          'FirstName': 'Ali',
                          'LastName': 'Muradov',
                          'IsManager': true,
                          'JoinedDate': '2022-04-16T00:00:00Z',
                          'Titles': [
                            'Senior Custom Developer',
                            'Skill: C#-ı Custom Yazmağ  '
                          ]
                        }";

            Employee employee = JsonConvert.DeserializeObject<Employee>(json);

            Console.WriteLine(employee.FirstName);
            Console.WriteLine(employee.LastName);
            Console.WriteLine(employee.JoinedDate);
            foreach (string title in employee.Titles)
            {
                Console.WriteLine("  {0}", title);
            }
        }
    }
    #endregion
    #region Serialize
    public class Object2
    {
        private object value;

        public Object2(object value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return base.ToString() + ": " + value.ToString();
        }
    }

    public class Example
    {
        public static void CustomSerilizer()
        {
            Object2 obj2 = new Object2('a');
            Console.WriteLine(obj2.ToString());
        }
    }
    #endregion
  

}
