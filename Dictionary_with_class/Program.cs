using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_with_class
{
    class Program
    {
       public static Dictionary<string, string> countries = new Dictionary<string, string>
        {
            ["Франция"] = "Париж",
            ["Германия"] = "Берлин",
            ["Великобритания"] = "Лондон"
        };
        static void Main(string[] args)
        {
            Dictionary<char, Person> people = new Dictionary<char, Person>();
            people.Add('b', new Person() { Name = "Bill" });
            people.Add('t', new Person() { Name = "Tom" });
            people.Add('j', new Person() { Name = "John" });

            foreach (KeyValuePair<char, Person> keyValue in people)
            {
                // keyValue.Value представляет класс Person
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value.Name);
            }

            // перебор ключей
            foreach (char c in people.Keys)
            {
                Console.WriteLine(c);
            }

            // перебор по значениям
            foreach (Person p in people.Values)
            {
                Console.WriteLine(p.Name);
            }

            foreach(KeyValuePair<string,string> keyvalue in countries)
            {
                Console.WriteLine(keyvalue.Key + " - " + keyvalue.Value);
            }
            Console.ReadKey();
        }
    }
    class Person
    {
        public string Name { get; set; }
    }
}
