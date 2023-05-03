using System.Text;

namespace E_Exception
{
    class Program
    {
        public void Main(string[] args)
        {
            //ExceptionHandler();
            FileHandler();
        }

         static void ExceptionHandler()
        {
            Console.WriteLine("Please input a number.");

            string result = Console.ReadLine();

            int number = 0;

            try
            {
                number = int.Parse(result);

            }
            catch (OverflowException ex)
            {
                //Можно отлавливать исключения точечно по их типам, т.е если упадет тип ошибки OverflowException, отлавливаем в текущем catch,
                // Если будет тип ошибки FormatException,отработает следующая ветка.

                Console.WriteLine("A format exeption has occured OverflowException.");
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("A format exeption has occured FormatExceptionl.");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                //Данный тип Exception(базовый) отлавливает все исключение,именно от этого объекта наследуються все исключения
                Console.Write("Catch Exeption ");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //Some logic
            }

            Console.WriteLine(number);
        }

         public void FileHandler()
         {
             // Создаем файла, параметр 1 = имя файла, 2 = операция с файлом (открыть или создать если не существует),
             // 3 = указываем доступ к файлу(т.е ReadWrite = читать и писать в созданном или найденом файле)
             Stream fs = new FileStream("text.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

             try
             {
                 string str = "Hello, world";
                 //кодируем строку в байты для записи в файл
                 byte[] strInBytes = Encoding.UTF8.GetBytes(str);

                 //параметры 1 = непосредственно закодированная строка, 2 = с какой позиции начинаем запись в файле(0 т.е cначала файла),
                 //3 = сколько символов записываем(в данном примере всю строку)
                 fs.Write(strInBytes,0, strInBytes.Length);

             }
             catch(Exception ex) 
             {
                Console.WriteLine(ex.Message);
             }
             finally
             {
                fs.Close();
             }
         }

    }
}
