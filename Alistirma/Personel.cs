using System;

namespace Alistirma
{
    public class Personel
    {
        private string tcKimlikNo;

        public string getTcKimlikNo
        {

            get
            {
                return tcKimlikNo.Substring(0, 5);
            }
            set
            {
                bool kontrol = false;
                if (value.Length == 11)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool sayiMi = char.IsNumber(value[i]);
                        if (!sayiMi)
                        {
                            kontrol = true;
                            break;
                        }
                    }

                    if (kontrol)
                    {
                        Console.WriteLine("Lütfen sadece sayı kullanınız");
                    }
                    else
                    {
                        tcKimlikNo = value;
                    }
                    //Console.WriteLine("TC Kimlik no 11 karakter uzunluğunda olmalı");
                }
                else
                {
                    Console.WriteLine("TC Kimlik no 11 karakter uzunluğunda olmalı");
                }

            }
        }
    }
}
