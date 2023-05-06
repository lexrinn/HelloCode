int[] array = {1, 12, 32, 44, 57, 73, 38, 89, 44};

int n = array.Length;
int find = 44;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    // index = index+1;
    index++;
}