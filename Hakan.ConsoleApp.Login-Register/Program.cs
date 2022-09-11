using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hakan.ConsoleApp.Login_Register
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhabalar, kanalımıza hoşgeldiniz. Kayıt yapmak için lütfen Kullanıcı adı ve Şifrenizi belirleyiniz.");
            Console.Write("Lütfen kullanıcı adınızı yazınız: ");
            string user = Console.ReadLine();
            Console.Write("Lütfen şifrenizi yazınız: ");
            string pass = Console.ReadLine();
            //bool block = true;
            int deneme = 3;

            Console.WriteLine($"{user} adlı hesabınız oluşturulmuştur. İyi günlerde kullanın.");
            Console.ReadLine();

            //while döngüsü için bool block=true; doğru girildiği zaman while=false.
            #region While
            //while (deneme <3)
            //{
            //    Console.WriteLine("Lütfen kanalımıza hesap bilgileriniz ile giriş yapınız: ");
            //    Console.WriteLine("Kullanıcı adınızı giriniz: ");
            //    string username = Console.ReadLine();
            //    Console.WriteLine("Şifrenizi giriniz: ");
            //    string password = Console.ReadLine();
            //    if (username == user && password == pass)
            //    { 
            //        block = false;
            //        Console.WriteLine("Evinize hoşgeldiniz. İyi eğlenceler.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hesap bilgileriniz yanlış, lütfen tekrar giriniz.");
            //    }
            //Console.ReadLine();
            //} 
            #endregion

            //for döngüsü için giriş sayısı 3ü geçmemeli.
            for (int giriş = 0; giriş < 3; giriş++)
            {
                Console.WriteLine("Lütfen kanalımıza hesap bilgileriniz ile giriş yapınız.");
                Console.Write("Kullanıcı adınızı giriniz: ");
                string username = Console.ReadLine();
                Console.Write("Şifrenizi giriniz: ");
                string password = Console.ReadLine();
                if (username == user && password == pass)
                {
                    Console.WriteLine("Kanalımıza hoşgeldiniz. İyi eğlenceler.");
                    Console.ReadLine();
                    break;
                }
                else if (deneme == 1)
                {
                    Console.WriteLine("Hesabınız yanlış girişten dolayı bloklanmıştır. İyi günler.");
                }
                else
                {
                    deneme = 2 - giriş;
                    Console.WriteLine($"Yanlış bir giriş yaptınız, tekrar denemek için herhangi bir tuşa basınız. Bloklanmadan önce {deneme} denemeniz kaldı.");
                }
                Console.ReadLine();
            }



        }
    }
}
