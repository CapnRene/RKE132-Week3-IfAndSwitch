Console.WriteLine("Enter a number:");
int userNum =Convert.ToInt32(Console.ReadLine());

// kas kasutaja arv on paaris v6i paaritu
int result = userNum % 29;
Console.WriteLine(result);

if (result != 0) // is not operaator
{
    Console.WriteLine("Number is odd");
}
else
{
    Console.WriteLine("Number is even");
}