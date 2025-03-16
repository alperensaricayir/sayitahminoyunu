using System;

namespace SayiTahminOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rastgele sayı üretmek için Random sınıfı kullanılır
            Random rastgele = new Random();
            int tutulanSayi = rastgele.Next(1, 101); // 1 ile 100 arasında sayı (101 dahil değil)

            int tahmin = 0; // Kullanıcının tahmini
            int tahminSayisi = 0; // Kaç tahmin yapıldığını sayar

            Console.WriteLine("🎮 Sayı Tahmin Oyununa Hoş Geldiniz!");
            Console.WriteLine("1 ile 100 arasında tuttuğum sayıyı tahmin edin!");

            // Kullanıcı doğru bilene kadar oyun devam eder
            while (tahmin != tutulanSayi)
            {
                Console.Write("Tahmininizi girin: ");

                // Kullanıcının girdiği sayıyı alıyoruz ve tam sayıya çeviriyoruz
                tahmin = Convert.ToInt32(Console.ReadLine());
                tahminSayisi++; // Her tahmin yapıldığında sayacı artırıyoruz

                // Kullanıcının tahminine göre yönlendirme yapıyoruz
                if (tahmin < tutulanSayi)
                {
                    Console.WriteLine("Daha büyük bir sayı deneyin! 📈");
                }
                else if (tahmin > tutulanSayi)
                {
                    Console.WriteLine("Daha küçük bir sayı deneyin! 📉");
                }
                else
                {
                    // Doğru tahmin durumunda
                    Console.WriteLine($"🎉 Tebrikler! {tahminSayisi} denemede doğru bildiniz. Tuttuğum sayı: {tutulanSayi}");
                }
            }

            // Oyun sonunda kullanıcıyı bilgilendirme
            Console.WriteLine("Oyunu kazandınız! Çıkmak için bir tuşa basın...");
            Console.ReadKey(); // Program kapanmasın diye
        }
    }
}
