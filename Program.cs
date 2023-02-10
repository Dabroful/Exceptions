using System;

namespace Isklucheniya
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var i = 5;
                var j = i / 0;
                Console.WriteLine(j);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Работа завершена");
            }
            
            while (true)
            {
                var input = Console.ReadLine();
                
                //проверяем ввод на интовое значение
                if (int.TryParse(input, out int result))
                {
                    Console.WriteLine($"Интовый {result}");
                }
                else
                {
                    Console.WriteLine("некорректный ввод");
                }
            }

        }
    }
}