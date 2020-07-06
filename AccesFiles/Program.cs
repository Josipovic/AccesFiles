using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace AccesFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            // read
            string FilePath = @"C:\Users\Katarina\Desktop\tekst.txt";
            //List<string> lines = File.ReadAllLines(FilePath).ToList();

            //foreach (string line in lines) 
            //{
            //    Console.WriteLine(line);
            //}

            ////write 
            //lines.Add("anka,marko,silvija");

            //File.WriteAllLines(FilePath,lines);


            //read
            List<Person> people = new List<Person>();
            List<string> list = File.ReadAllLines(FilePath).ToList();
            foreach (var line in list)
            {
                string[] entries = line.Split(',');
                Person p = new Person();
                p.FirstName = entries[0];
                p.LastName = entries[1];
                p.Url = entries[2];
                people.Add(p);
            }

            foreach (var person in people) 
            {
                Console.WriteLine(person.FirstName);
                Console.WriteLine(person.LastName);
                Console.WriteLine(person.Url);
            }


            //write
            people.Add(new Person
            {
                FirstName = "Ivan",
                LastName="Ivic",
                Url="ivan@gmail.com"
            });
            List<string> output = new List<string>();
            foreach (var person in people)
            {
                output.Add($"{person.FirstName},{person.LastName},{person.Url}");
               
            }

            File.WriteAllLines(FilePath,output);
            Console.ReadLine();
        }
    }
}
