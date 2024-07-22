Message();
Console.WriteLine(Rastgele());
Console.WriteLine(carpım(5, 10));
nameMethod("Emre Can", "TERKAN");

//1.Pratik.
static void Message()
{
    Console.WriteLine("Sebepsiz boş yere ayrılacaksan...");
}
//2.Pratik.
int Rastgele()
{
    Random random = new Random();
    int y = random.Next();
    return y % 2;

}
//3.Pratik.
int carpım(int x, int y)
{
    return x * y;
}

//4.Pratik.
void nameMethod(string name, string lastname)
{

    Console.WriteLine($"Hoşgeldiniz {name} {lastname}");

}