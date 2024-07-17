Console.Write("Lütfen bir sayı giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());

//Kullanıcı tarafından girilen sayısının 10 dan büyük mü,küçük mü,eşit mi olduğu kontrol ediliyor.
if (sayi>10)
{
    Console.WriteLine("Girilen sayı 10'dan büyük");
}
else if(sayi==10)
{
    Console.WriteLine("Girilen sayı 10'a eşit");
}
else if (sayi < 10)
{
    Console.WriteLine("Girilen sayı 10'dan küçük");
}

//Kullanıcı tarafından girilen sayısının çift mi tek mi olduğu kontrol ediliyor.
if(sayi%2==0)
{
    Console.WriteLine("Girilen sayı çifttir.");
}
else
{
    Console.WriteLine("Girilen sayı tektir.");
}