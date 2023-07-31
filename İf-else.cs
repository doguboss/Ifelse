Console.WriteLine("Id giriniz");
string ıd = Console.ReadLine();
Console.WriteLine("Şifre giriniz");
string pass = Console.ReadLine();

if (ıd == "Admin" && pass =="123")
{
    Console.WriteLine("Hoşgeldiniz");
}
else if (ıd != "admin")
{
    Console.WriteLine("Kullanıcı adı yanlış");
    Environment.Exit(0);
}
else
{
    Console.WriteLine("şifre yanlış");
    Environment.Exit(0);
}
Console.WriteLine("devam etmek istiyorsanız 1 tıklayın istemiyorsanız 2 ");
     ConsoleKeyInfo keyInfo = Console.ReadKey();

if (keyInfo.KeyChar=='1')
{
    Console.WriteLine("  Devam ediliyor  ");
    Console.WriteLine("  PANELİMİZE HOŞ GELDİNİZ");
    Console.WriteLine("Hangi bölüme gitmek istersiniz?");
    Console.WriteLine("1 - Muhasebe");
    Console.WriteLine("2 - İnsan Kaynakları");
    Console.WriteLine("3 - Diğer Bilgiler");
    Console.Write("Seçiminizi yapın (1, 2 veya 3): ");

    string secim = Console.ReadLine(); // Kullanıcının seçimini alır.

    if (secim == "1")
    {
        Console.WriteLine("Muhasebe bölümüne yönlendiriliyorsunuz.");
        Console.WriteLine("Muhasebe e-posta  muhasebe.com.tr@gmail.com");
        // Muhasebe ile ilgili işlemleri burada yapabilirsiniz.
    }
    else if (secim == "2")
    {
        Console.WriteLine("İnsan Kaynakları bölümüne yönlendiriliyorsunuz.");
        Console.WriteLine("İnsan kaynakaları e-posta insankaynakları.com.tr@gmail.com");
        // İnsan Kaynakları ile ilgili işlemleri burada yapabilirsiniz.
    }
    else if (secim == "3")
    {
        Console.WriteLine("Diğer bilgiler için yönlendiriliyorsunuz.");
        // Diğer konular ile ilgili işlemleri burada yapabilirsiniz.
    }
    else
    {
        Console.WriteLine("Geçersiz seçim. Lütfen 1, 2 veya 3 tuşlarından birini seçin.");
    }

    Console.ReadKey();
    Console.ReadKey();
}
else
{
    Console.WriteLine("geldiniz için teşekkür ederiz");
}