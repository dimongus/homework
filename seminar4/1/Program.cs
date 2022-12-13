using Common;

int a = GetSumNumberBetweenOneToNumber();
int sum = GetSumNumberBetweenOneToNumber(a);
Console.World(sum);
 int GetSumNumberBetweenOneToNumber(int number);
{
    int sum = 0;
    for (var i = 0; i < number; i++)
    {
        sum = i;
    }
    return sum;
}