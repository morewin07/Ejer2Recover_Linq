using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Ejer3LinqPractice_SecondTry
{
    class Program
    {
        static void Main(string[] args)
        {

            //Exercise1

            String Json = File.ReadAllText("Cars.json");
            List<Car> Cars = JsonConvert.DeserializeObject<List<Car>>(Json);

            Console.ReadKey();

        }

        //Exercise2
        public static void Ejer2(List<Car> Cars)
        {

            var list = Cars.GroupBy(x => x.Maker).Select(y => y.First());

            foreach (var i in list)
            {

                Console.WriteLine($"Maker: {i.Maker}");

            }

        }

        //Exercise3
        public static void Ejer3(List<Car> Cars)
        {

            var list = Cars.GroupBy(x => x.Color).Select(y => y.First());

            foreach (var i in list)
            {

                Console.WriteLine($"Maker : {i.Maker} Model : {i.Model}");

            }

        }

        //Exercise4
        public static void Ejer4(List<Car> Cars)
        {

            var list = Cars.Where(x => x.Color == "Green");

            foreach (var i in list)
            {

                Console.WriteLine($"Maker : {i.Maker} Model : {i.Model}");

            }

        }

        //Exercise5
        public static void Ejer5(List<Car> Cars)
        {

            double Latitude = 0;
            double Longitude = 0;

            var list = Cars.Where(x => x.Location.Latitude == Latitude && x.Location.Longitude == Longitude);

            foreach (var i in list)
            {
                if (i.Year == 1992)
                {

                    Console.WriteLine($"There are cars");

                }
                else
                {

                    Console.WriteLine($"There are not cars");

                }
            }


        }

        //Exercise6
        public static void Ejer6(List<Car> Cars)
        {

            var list = Cars.Where(x => x.Year > 2001);

            foreach (var i in list)
            {

                Console.WriteLine(i);

            }

        }

        //Exercise7
        public static void Ejer7(List<Car> Cars)
        {

            var list = Cars.Where(x => x.Location.Latitude == null && x.Location.Longitude == null);

            foreach (var i in list)
            {

                Console.WriteLine($"Model: {i.Model} Maker: {i.Maker}");

            }

        }

        //Exercise8
        public static void Ejer8(List<Car> Cars)
        {

            var list = Cars.Where(x => x.Color == "Blue" && x.Year < 2000);

            foreach (var i in list)
            {

                Console.WriteLine(i);

            }

        }

        //Exercise9
        public static void Ejer9(List<Car> Cars)
        {

            var list = Cars.OrderBy(x => x.Year).GroupBy(x => x.Maker);


            foreach (var i in list)
            {

                Console.WriteLine(i);

            }

        }

        //Exercise10
        public static void Ejer10(List<Car> Cars)
        {

            var list = Cars.GroupBy(x => x.Model);

            var color = Cars.Select(y => y.Color).First();

            foreach (var i in list)
            {

                Console.WriteLine(i);

            }

            foreach (var x in color)
            {

                Console.WriteLine(x);

            }

        }


        //Exercise11
        public static void Ejer11(List<Car> Cars)
        {

            int position = 0;
            var list = Cars.Take(10);

            try
            {
                do
                {
                    foreach (var x in list)
                    {

                        Console.WriteLine(x);

                    }

                    Console.ReadLine();

                    position += 10;
                    list = Cars.Skip(position).Take(10);

                } while (list != list.Last());

            }
            catch (InvalidOperationException)
            {

                Console.WriteLine("No more cars");

            }
        }

        //Exercise12
        public static void Ejer12(List<Car> Cars)
        {

            var FirstSuzuki = Cars.Where(x => x.Year > 2001 && x.Maker == "Suzuki").Take(1);

            foreach (var i in FirstSuzuki)
            {

                Console.WriteLine(i);

            }

        }

        //Exercise13
        public static void Ejer13(List<Car> Cars)
        {

            var list = Cars.Where(x => x.Year != null);

            foreach (var i in list)
            {

                Console.WriteLine(i);

            }

        }

        //Exercise14
        public static void Ejer14(List<Car> Cars)
        {

            var list = Cars.GroupBy(x => x.Year);

            var count = Cars.Count(y => y.Color == "Pink");
            
            foreach (var i in list)
            {

                Console.WriteLine(i);

            }

            Console.WriteLine($"Number of pink cars: {count}");

        }

        //Exercise15
        public static void Ejer15(List<Car> Cars)
        {

            var list = Cars.Where(x => x.Maker == "BMW" && x.Year == null && string.IsNullOrEmpty(x.Color));

            foreach (var i in list)
            {

                Console.WriteLine(i);

            }

        }

        //Exercise16
        public static void Ejer16(List<Car> Cars, string color, int year)
        {

            var list = Cars.Where(x => x.Color != color && x.Year != year);

            foreach (var i in list)
            {

                Console.WriteLine(i);

            }

        }

    }
}
