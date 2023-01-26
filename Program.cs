using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NewAppMetodZ4
{

    internal class Program
    {

        static int CheckValue()
        {
            int correctValue;
            while (!int.TryParse(Console.ReadLine(), out correctValue))
            {
                Console.WriteLine("Неправильно! Попробуй еще раз.");
            }
            return correctValue;
        }

        public static bool IsValidInput(string input)
        {
            string[] splitInput = input.Split(" ");

            for (int i = 0; i < splitInput.Length; i++)
            {

                bool success = int.TryParse(splitInput[i], out int number);

                if (success == false)
                {
                    return false;
                }
            }

            return true;
        }



        /// <summary>
        /// Конвертация массива строк в массив чисел
        /// </summary>
        /// <param name="arrayint">Массив в каторой запишут числа</param>
        /// <param name="arraystr">Массив из которого берут строку</param>
        static void ConvertToInt(int[] arrayint, string[] arraystr)
        {
            for (int j = 0; j < arraystr.Length; j++)
            {
                arrayint[j] = Convert.ToInt32(arraystr[j]);
            }

        }
        /// <summary>
        /// Выполнение Арифметичекой прогрессии
        /// </summary>
        /// <param name="countA">Счетчи считающий кол-во выполненых итераций для Арифмет. пр.</param>
        /// <param name="Array">Массив с числами</param>
        /// <returns></returns>
        static bool Arifmetich(int[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                int d = Array[1] - Array[0];

                if (Array[i] != Array[1] + d * (i - 1))          //(numb[i + 1] == (numb[i]+ numb[i+2])/2)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Выполнение Геометричекой прогрессии
        /// </summary>
        /// <param name="countG">>Счетчи считающий кол-во выполненых итераций</param>
        /// <param name="Array">Массив с числами</param>
        /// <returns></returns>
        static bool Geometric(int[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] == 0)
                {
                    return false;
                }
                else
                {
                    int q = Array[1] / Array[0];

                    if (Array[i] != Array[1] * Math.Pow(q, (i - 1)))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        /// <summary>
        /// Определение какая прогрессия была выполнена
        /// </summary>
        /// <param name="countA">Счетчи считающий кол-во выполненых итераций для Арифмет. пр.</param>
        /// <param name="countG">Счетчи считающий кол-во выполненых итераций для Геометр. пр.</param>
        /// <param name="Array">Массив с числами</param>
        static void Opredelenie(bool restArifm, bool resGeom)
        {
            if (restArifm == true)
            {
                Console.WriteLine("Арифметическая прогрессия");
            }
            else if (resGeom == true)
            {
                Console.WriteLine("Геометрическая прогрессия");
            }
            else
            {
                Console.WriteLine("Нет такой прогрессии");
            }
        }


        static void Main(string[] args)
        {


            // Задание 4. Написать метод принимающий некоторое количесво чисел, выяснить
            // является заданная последовательность элементами арифметической или геометрической прогрессии

            Console.Write("Введи целые числа через пробел: ");
            string input = Console.ReadLine();

            bool res = IsValidInput(input);

            if (res == false)
            {
                return;
            }

            string[] splitInput = input.Split(' ');

            int[] numb = new int[splitInput.Length];



            ConvertToInt(numb, splitInput);

            bool restArifm = Arifmetich(numb);

            bool resGeom = Geometric(numb);

            Opredelenie(restArifm, resGeom);



            //for (int i = 0; i < Split_Input.Length; i++)  // Конвертирование цикла string в int
            //{
            //    for (int j = 0; j < Split_Input.Length; j++)
            //    {
            //        numb[j] = Convert.ToInt32(Split_Input[j]);
            //    }
            //}

            //for (int i = 0; i < numb.Length; i++)
            //{
            //    int d = numb[1] - numb[0];

            //    if (numb[i] == numb[1] + d * (i - 1))          //(numb[i + 1] == (numb[i]+ numb[i+2])/2)
            //    {
            //        countArifm++;
            //    }
            //}

            //for (int i = 0; i < numb.Length; i++)
            //{
            //    if (numb[i] == 0)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        int q = numb[1] / numb[0];

            //        if (numb[i] == numb[1] * Math.Pow(q, (i - 1)))
            //        {
            //            countGeom++;
            //        }
            //    }
            //}

            //if (countArifm == numb.Length)
            //{
            //    Console.WriteLine("Арифметическая прогрессия");
            //}
            //else if (countGeom == numb.Length)
            //{
            //    Console.WriteLine("Геометрическая прогрессия");
            //}
            //else 
            //{
            //    Console.WriteLine("Нет такой прогрессии");
            //}



        }
    }
}