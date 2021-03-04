using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ismail candan
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "İsmail";
            musteri1.Soyadı = "Candan";
            musteri1.TcNo = "12345678910";

            //kodlama.io girişi
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            //Gerçek Müşteri - Tüzel Müşteri
            //SOLİD - L (Bunu alatır)

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);

            Console.WriteLine("Hello World!");
        }
    }
}
