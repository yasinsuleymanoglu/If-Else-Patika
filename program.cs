internal class Program


static void Main ()
  // Karar_Yapıları
 {
     #region If Else

     int time = DateTime.Now.Hour;
     if (time < 12 && time > 0)
     {
         Console.WriteLine("Günaydın!");

     }
     else if (time == 12)
         Console.WriteLine("Tünaydın");
     else if (time > 12 && time < 18)
         Console.WriteLine("İyi günler!");

     else if (time >= 18 && time <= 0)
         Console.WriteLine("İyi akşamlar.");
     else
     {
         Console.WriteLine("İyi geceler");
     }
     // kodu daha sadeleştirmek istersek
     // ? den sonra gelen ilk çalışır : dan sonra gelen else gibi düşünülebilir
     string sonuc = time <= 12 ? "İyi günler" : "İyi akşamlar";
     Console.WriteLine(sonuc);
     // Yukarıda yazdığımızın aynısını ? ve : ile tekrar yazalım 
     string sonuc1 = time < 12 && time > 0 ? "Günaydın!" : time == 12 ? "Tünaydın" :
         time > 12 && time < 18 ? "İyi günler!" : time >= 18 && time <= 0 ? "İyi akşamlar." : "İyi Geceler!";
     Console.WriteLine(sonuc1);
     #endregion
