using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTraning
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(getCharCount("а", "МолАко")); 
            //Console.WriteLine(ChangeCase("ИзМеНиТь симвоЛы"));
            //Console.WriteLine(IsContains("adf","sdf"));
            //Comparing("МАМА мыла раму", "мама мыла раму", true);
            //Console.WriteLine(ReturnCount("Мама Мыла автомоб ОЛД ол"));     ????????????????????????
            //Change("В жизни много +++");
            //ChangeLarge("В жизни много +++");
            //Dot("Мама мыла раму. Очень часто.");
            //Reverser("Мама мыла раму"); // ???????????????????????????
            // Contain("aaaa","aa");
            // ReturnPercent("Мама мыла раму очень усердно.");
            //Funk("Мама", "амам");
            // Mass("каждый охонтик желает знать где сидит фазан");
            //Console.WriteLine(getCharCountv2("маМа мыла раму","мама"));
            Console.WriteLine(  GetLastChar("мама мыла раму"));
        }

        //1
        ////Разработайте функцию getCharCount которая принимает символ и строку
        ////и возвращает количество таких символов в строке
        ////если вместо символа передана строка, то в качестве символа используется первый символ этой строки.
        ////регистр значения не имеет

        static int getCharCount(string a, string b)
        {
            int result = 0;
            char[] str = b.ToLower().ToCharArray();
            char[] symb = a.ToLower().ToCharArray();
            foreach (char c in str)
            {
                if (c == symb[0])
                    result++;
            }
            return result;
        }

        static int getCharCountv2(string a, string b)
        {
            return ((a.Length) - a.ToLower().Replace(b.ToLower().Substring(0, 1), "").Length);
        }


        //2
        ////Разработайте функцию changeCase, которая принимает строку как аргумент 
        ////в полученной строке заменяем регистр у каждого из символов
        ////Например changeCase("Строка") -- "сТРОКА"

        static string ChangeCase(string str)
        {
            char[] charStr = str.ToCharArray();
            for (int i = 0; charStr.Length > i; i++)
            {
                if (char.IsUpper(charStr[i]))
                {
                    charStr[i] = char.ToLower(charStr[i]);
                }
                else charStr[i] = char.ToUpper(charStr[i]);
            }
            string result = new string(charStr);
            return result;
        }

        //3
        ////Разработайте функцию contains, которая принимает 2 строки в качестве аргументов
        ////функция возвращает true, если втророй аргумент является подстрокой первого аргумента
        ////null если один или оба аргумента -- пустые строки
        ////иначе false

        static string IsContains(string a, string b)
        {
            string result = "";
            if (true == (a.Contains(b)))
            {
                if (a == "" || b == "")
                {
                    return (result = "null");
                }
                return (result = "true");
            }
            else return (result = "false");
        }

        //4
        ////Разработайте функцию contains, которая принимает 2 строки в качестве аргументов
        ////функция возвращает количество вхождений второй строки в первую
        ////если одна из строк пустая то 0

        static void Contain(string a, string b)
        { int res = 0;
            if (a!="" || b!="")
            {
                Console.WriteLine((a.Length - a.Replace(b, "").Length)/ b.Length);
            }
            else Console.WriteLine(res);
        }

        static int ContainV2(string a, string b)
        {
            if (a == "" || b == "")
                return 0;
            else
                return (a.Length - a.Replace(b, "").Length) / b.Length;
        }

        //5
        ////Разработайте функцию Compare, которая производит сравнение строк с учетом или без учета регистра
        ////параметры 1 и 2 - это сравниваемые строки. Параметр 3 логический флаг
        ////true -- регистр учитывается, false -- нет

        static void Comparing(string a, string b, bool flag)
        {
            Console.WriteLine(" Is string {0} == {1}?: {2} ", a, b, string.Compare(a, b, flag));
        }

        //6
        ////Разработайте функцию remove3, которая принимает строку
        ////и удаляет из этой строки 3 слова,
        ////которые занимают 3-5 места при сортировке слов по алфавиту
        ////оставшиеся слова возвращаются в отсортированном по алфавиту массиве.
        ////слова в строке разделяются пробелом.

        static void Mass(string s)
        {
            string[] stMass = s.Split(' ');
            foreach (string st in stMass)
                Console.Write("\t{0}", st);
            Console.WriteLine();

            Array.Sort(stMass);
            foreach(string st in stMass)
                Console.Write("\t{0}",st);
            Console.WriteLine();

            Array.Clear(stMass, 2, 3);
            List<string> arr = new List<string>();
            for (int i = 0; i < stMass.Length; i++)
                if (stMass[i] != null)
                {
                    arr.Add(stMass[i]);
                }
            
            Console.WriteLine();
        }

        //7
        //Реализовать функцию, которая принимает строку и возвращает строку, составленный из последних букв всех слов.
         static string GetLastChar(string s)
        {
            string[] arr = s.Split(' ');
            string resulta = "";
            foreach(var a in arr)
            {   if (a != "")
                {
                    resulta += a[a.Length - 1];
                }
            }
            return resulta;
        }


        //8 
        //Реализовать функцию, которая принимает строку и возвращает количество слов, начинающихся с прописной буквы.
        static int ReturnCount(string a)
        {
            int result = 0;
            char[] cStr = a.ToCharArray();
            for (int i = 0; cStr.Length > i; i++)
            {
                if (char.IsUpper(cStr[i]) && (cStr[i - 1] == ' ' || i == 0))
                { result++; }
            }
            return result;
        }

        static int ReturnCountV2(string a)
        {
            int count = 0;
            string[] arr = a.Split(' ');
            foreach (var ar in arr)
            {
                if (char.IsUpper(ar[0]))
                    count++;
            }
            return count;
        }

        //9) 
        //Реализовать функцию, которая принимает строку, заменяет все согласные символы на ‘%’ и возвращает новую строку.
        //Для решения задачи использовать тип StringBuilder.

        static void ReturnPercent(string s)
        {
            StringBuilder sb = new StringBuilder(s);
            string workStr = "bcdfghjklmnpqrstvwxzBCDFGHJKLMNPQRSTVWXZбвгджзклмнпрстфхцчшщъБВГДЖЗКЛМНПРСТФХЦЧШЩЪ";
            for (int i = 0; sb.Length > i; i++)
            {
                if (workStr.Contains(sb[i]))
                    sb.Replace(sb[i], '%');
            }
            Console.WriteLine(sb);
            
        }

        //10) 
        //Дан текст, слова разделены пробелами.Реализовать функции, которые принимаю этот текст и выполняют необходимые манипуляции над ним
        //Функция 1. Преобразует все слова по правилу: удалить из слова все последующие вхождения первого символа
        //Функция 2. Преобразует все слова по правилу: оставить в слове только последние вхождения каждого символа
        //Реализовать на C# с помощью стандартных функций класса String, StringBuilder (без использования регулярных выражений)

        static string FirstFunction(string a)
        {
            string[] sb = a.Split(' ');
            foreach (var s in sb)
            {
                s.Replace(s[0].ToString(), "");
            }
            return string.Join(" ", sb);  
        }

        static void SecondFunction(string a)
        {
            string[] st = a.Split(' ');
            foreach (var s in st)
            {
                for (int i = 0; i < s.Length; i++)
                {
                   s.LastIndexOfAny()
                }
            }
        }

        //11) 
        //Реализовать функцию, которая принимает текст и заменяет в нем все символы ‘+’ на ‘—‘.
        static string Change(string s)
        {
           return s.Replace('+','-');
        }

        //12) 
        //Реализовать функцию, которая принимает текст и заменяет в нем все символы ‘+’ на ‘+++’.
        static string ChangeLarge(string s)
        {
            return s.Replace("+","+++");
        }

        //13) 
        //Реализовать функцию, которая принимает текст и определяет в нем позицию первой точки ‘.‘. Считать, что первый символ в строке имеет позицию 1.
        static int Dot(string s)
        {
            return s.IndexOf('.',0)+1;
        }

        //14)
        //Реализовать функцию, которая принимает строку и возвращает новую строку образованную реверсом заданной строки.


        static string Reverser(string s)
        {
            char[] res = s.ToCharArray();
            Array.Reverse(res);
            string result = new string(res);
            return result; 
        }

        //15) 
        //Реализовать функцию, которая принимает две строки(слова) и проверить, есть ли данные слова обратными между собой,
        // то есть первое слово читается слева направо так же, как второе слово справа налево.


        static void Funk(string a, string b)
        { string ret = "";
            string first = Reverser(a);
            int res = string.Compare(first.ToLower(), b.ToLower());
            if (res == 0) { ret = "true"; }
            else { ret = "false"; }
            Console.WriteLine("Is thees string: {0}, {1} are reversed? {2}",a,b,ret );
        }
    }
}
