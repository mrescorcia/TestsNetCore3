using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tests
{
    class Program : Menu
    {
        
        static void Main()
        {
            new Program().Golosinas();
            
        }
    }

    public class ListFilterer
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            /*List<int> newListOut = new List<int>();
            foreach (var a in listOfItems)
            {
                if(a.GetType().Name == "Int32")
                {
                    newListOut.Add(Convert.ToInt32(a.ToString()));
                }
            }

            return newListOut;*/

            return listOfItems.OfType<int>();
        }
        
    }

    public class CSharpCourse
    {
        public static void SwitchExpressions()
        {
            var data = 2;
            var results = data switch
            {
                1 => "David",
                2 => "Daniel",
                _ => "No Name"
            };
            Console.Write(results);
            Console.ReadLine();
        }

        public static void IteratingStrings()
        {
            string test = "Hi, this is a test";
            foreach(Char a in test)
            {

            }
        }

        public static void PlayingWithStrings()
        {
            //string str1 = "Hi World";
            StringBuilder str2;
            //str1[0] = 'h'; //-- Only read
            //str2[0] = 'h';
            
            str2 = new StringBuilder("Hi");
            str2.Capacity = 10;
            str2.Append(" ");
            str2.Append("World");
            str2.Append(" Two");
            str2.Append(" Tomorrow");
            Console.WriteLine(str2);
            Console.ReadLine();
        }

        public static void ParametersOfMethods()
        {
            int data;
            new CSharpCourse().ParametersOfMethodsTwo(out data);
            Console.WriteLine(data);
            Console.ReadLine();
        }

        private void ParametersOfMethodsTwo(out int valor)
        {
            valor = 50 + 20;
        }
    }
    
}
