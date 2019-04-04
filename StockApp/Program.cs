using System;

namespace StockApp.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                System.Console.WriteLine("Для добавления нажмите Enter");
                if (System.Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    XmlAdder xmlAdder = new XmlAdder();
                     
                    Product product = new Product();
                    product.AddPressed += new AdderDelegate(xmlAdder.AddProduct);

                    System.Console.WriteLine("Введите название товара:");
                    product.Name = System.Console.ReadLine();

                    while (true)
                    {
                        System.Console.WriteLine("Введите массу товара");
                        try
                        {
                            product.Weight = int.Parse(System.Console.ReadLine());
                            if (product.Weight < 0 || product.Weight > 100000)
                                throw new Exception();
                        }
                        catch (Exception)
                        {
                            System.Console.WriteLine("Неверный ввод!");
                            continue;
                        }
                        break;
                    }

                    while (true)
                    {
                        System.Console.WriteLine("Введите объем товара");
                        try
                        {
                            product.Volume = int.Parse(System.Console.ReadLine());
                            if (product.Volume < 0)
                                throw new Exception();
                        }
                        catch (Exception)
                        {
                            System.Console.WriteLine("Неверный ввод!");
                            continue;
                        }
                        break;
                    }

                    product.ArriveDate = DateTime.Now;

                    product.Add();

                    System.Console.Clear();
                    System.Console.WriteLine("Товар успешно добавлен!");
                    System.Console.WriteLine();
                }
            }
        }
    }
}
