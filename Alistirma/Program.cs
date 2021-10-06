using System;

namespace Alistirma
{
    class Program
    {

        /// <summary>
        /// set şartları; 
        /// 1- Tc kimlik no 11 karakter olmalı
        /// 2- Tüm karakterler sayısal karakter olmalı
        /// 
        /// get şartı;
        /// Tc kimlik no ilk 5 karakteri alınacak
        /// </summary>
        static void Main(string[] args)
        {
            Personel p1 = new Personel();
            p1.getTcKimlikNo = "12345678912";
            Console.WriteLine("TC Kimlik No: " + p1.getTcKimlikNo + "******");
        }
    }
}
