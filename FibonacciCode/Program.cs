Console.WriteLine("***");
Console.WriteLine("The Fibonacci's Sequence");
Console.WriteLine("***");

int a = 0;
int b = 1;
int c;

for (int i = 0; i < 10; i++)
{
    c = a + b;
    a = b;
    b = c;
    Console.WriteLine(c);

}

