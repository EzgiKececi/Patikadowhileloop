//while döngüsü

int sayac= 0;
Console.WriteLine("Lütfen bir değer giriniz: "); // değer konsolda -5 olarak girildi.
int limit = Convert.ToInt32(Console.ReadLine());
/*while (sayac <= limit)
{
    Console.WriteLine("Ben bir Patikalıyım.");
    sayac++;
}*/

//do - while döngüsü

do
{
  
    Console.WriteLine("Ben bir Patikalıyım.");
    sayac++;

}while(sayac <= limit); 


//Her iki döngüde de 10 değeri girildiğinde konsola 11 kez cümle yazdırıldı.
//-5 değeri girildiğinde while döngüsü koşulu en başta kontrol ettiği için ekrana yazı yazdırmadı yani döngüye girilmedi.
//do-while döngüsünde ise koşul en sonda kontrol edildiği için ekrana bir kez cümle yazdı.