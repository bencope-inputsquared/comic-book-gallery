double average_a = 1.0;
int average_b = 0;
int count = 0;
for (int i = 2; i < 100; i++)
{
    average_a += i;
    average_b += i;
    average_a /= 2.0;
    count = i;
}
average_b /= count;

Console.WriteLine($"{average_a} - {average_b}");