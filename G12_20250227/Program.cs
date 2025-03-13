namespace G12_20250227
{
    internal class Program
    {
        static void Main()
        {
            Car[] cars = new Car[]
            {
                new Car { Make = "Toyota", Model = "Camry", Year = 2020 },
                new Car { Make = "Honda", Model = "Civic", Year = 2019 },
                new Car { Make = "Ford", Model = "Mustang", Year = 2021 },
                new Car { Make = "Chevrolet", Model = "Malibu", Year = 2018 },
                new Car { Make = "Nissan", Model = "Altima", Year = 2022 },
                new Car { Make = "BMW", Model = "3 Series", Year = 2020 },
                new Car { Make = "Audi", Model = "A4", Year = 2019 },
                new Car { Make = "Mercedes-Benz", Model = "C-Class", Year = 2021 },
                new Car { Make = "Volkswagen", Model = "Passat", Year = 2018 },
                new Car { Make = "Hyundai", Model = "Elantra", Year = 2022 }
            };
            
            Book[] books = new Book[]
            {
                new Book { Author = "Lev", Pages = 1321, Title = "War" },
                new Book { Author = "Dostoevskiy", Pages = 21, Title = "Pain" },
                new Book { Author = "Gogol", Pages = 321, Title = "A" }
            };
            
             /* sortNumber:
                 Default 0: Sort by int (Year, Pages)
                         1: Sort by string Name (Make, Author)
                         2: Sort by string Model (Model, Title)
             */

            ArrayHelper.Sort(cars);

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
        }
    }
}
