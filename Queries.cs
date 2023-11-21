namespace LINQ_005
{
    internal class Queries
    {
        public static void Run()
        {
            var allGuys = new List<Guys>()
            {
                new Guys {StudentId = 1,Name = "John",Age = 18},
                new Guys {StudentId = 2,Name = "Steve",Age = 21},
                new Guys {StudentId = 3,Name = "Bii",Age = 18},
                new Guys {StudentId = 4,Name = "Ram",Age = 20},
                new Guys {StudentId = 5,Name = "Abram",Age = 21},
            };


            /* GroupBy && ToLookUp //sinxron && asinxron
            var result = from student in allGuys
                         group student by student.Age;

            var result2 = allGuys.ToLookup(x => x.Age);

            foreach ( var guy in result)
            {
                Console.WriteLine($"Key buyicha:{guy.Key}");
               
                foreach ( var guy2 in guy)
                {
                    Console.WriteLine(guy2.Name);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n\n");

            foreach (var guy in result2)
            {
                Console.WriteLine($"Key buyicha:{guy.Key}");

                foreach (var guy2 in guy)
                {
                    Console.WriteLine(guy2.Name);
                }
                Console.WriteLine();
            }
            */


            var strList_1 = new List<string>() { "One", "Two", "Three", "Four" };
            var strList_2 = new List<string>() { "One", "Two", "Five", "Six" };

            var innerJoin = strList_1.Join(strList_2,
                                        str1 => str1,
                                        str2 => str2,
                                        (str1, str2) => new
                                        {
                                            Item1 = str1,
                                            Item2 = str2,
                                        });



        }
    }
}
