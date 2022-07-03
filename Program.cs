// показать последнию цифру трехзначного числа
Console.WriteLine("введите трехзначное число число ");
int a= int.Parse(Console.ReadLine());
if (a>99 && a<1000)
{
Console.WriteLine("последняя цифра числа=");
Console.Write(a % 10);
}
else 
{
    Console.WriteLine("Число не трехзначное");
}

