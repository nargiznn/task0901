using System;
using System.Drawing;

namespace task0901
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello !");

            #region  Task1

            //Verilmiş email dəyərinin domain hissəni qaytaran metod
            //(elchin@code.edu.az email - i daxil edilsə code.edu.az hiss'sini qaytarmalıdır)
            // Console.WriteLine("Emaili daxil edin!");
            // string email = Console.ReadLine();
            //Console.WriteLine(domain(email));

            #endregion
            #region Task2
            //Verilmiş yazının yalnız hərflərdən ibarət olub olmadığını tapan metod
            //Console.WriteLine("Yazi daxil edin!");
            //string str = Console.ReadLine();
            //bool result = onlyletter(str);
            //Console.WriteLine(result);

            #endregion

            #region Task3
            //Verilmiş yazının ilk hərfini böyük qalanlarını kiçik edib qaytaran metod
            //(Misaçün "saLAm nEceSen" yazısı daxil edilsə metoddan "Salam necesen" return olmalıdır)
            //string text2 = "saLAm nEceSen";
            //string result1 = firstLetterBig(text2);
            //Console.WriteLine(result1);
            #endregion

            #region Task4
            //Verilmiş fullnamelər siyahısından name-lər siyahısı düzəldən metod
            //(ad soyadlar siyahısındaki adları kəsib yeni bir arraye doldurub qaytarmalıdır)
            //string[] fullnames = { "Aysel Esgerova", "Vaqif Məmmədov", "Musa Rəşidli", "Leyla Nadirli" };
            //string[] names = NewName(fullnames);
            //for(int i=0;i<names.Length;i++)
            //{
            //    Console.WriteLine(names[i]);
            //}

            #endregion
            #region Task5
            //Doğum tarixinizi daxil etdiyinizdə sizə yaşınızı qaytaran metod
            
            //DateTime birthday = new DateTime(2004, 01, 26);
            //int age = myage(birthday);
            //Console.WriteLine(age);
            #endregion
        }
        //static string domain(string email)
        //{
        //    int startIndex = email.IndexOf('@');
        //    var domain = email.Substring(startIndex + 1, email.Length - startIndex - 1);
        //    return domain;
        //}
        //static bool onlyletter(string text)
        //{
        //    for (int i = 0; i < text.Length; i++)
        //    {

        //        if (!char.IsLetter(text[i]))
        //        {
        //            return false;
        //        }


        //    }
        //    return true;

        //}
        //static string firstLetterBig(string text2)
        //{
        //    if(string.IsNullOrEmpty(text2))
        //    {
        //        return text2;
        //    }
        //    var newtext= text2.ToLower();
        //    char firstletter = char.ToUpper(newtext[0]);
        //    return firstletter + newtext.Substring(1);
        //}
        //static string[] NewName(string[]fullnames)
        // {
        //     string[] names = new string[fullnames.Length];
        //     for(int i=0;i<fullnames.Length;i++)
        //     {
        //         string[] namepart = fullnames[i].Split(' ');
        //         names[i] = namepart[0];
        //     }
        //     return names;
        // }
        //static int myage(DateTime birthday)
        //{
        //    DateTime today = DateTime.Today;
        //    int age = today.Year - birthday.Year;
        //    return age;
        //}
        



    }
}

