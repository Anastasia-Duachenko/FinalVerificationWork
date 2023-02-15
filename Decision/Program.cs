
Console.Clear();

string[] ReferToArray() 
{
    Console.Write("Введите значения через запятую: ");
    return Console.ReadLine().Split(",");
}

string[] array = ReferToArray();
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", SearchingForValues(array, 3))}]");

string[] SearchingForValues(string[] entry, int t) 
{
    string[] exit = new string[NumberOfValues(entry, t)];
    for(int i = 0, j = 0; i < entry.Length; i++) 
    {
        if(entry[i].Length <= t) 
        {
            exit[j] = entry[i];
            j++;
        }
    }

    return exit;
}

int NumberOfValues(string[] entry, int t) 
{
    int count = 0;
    for(int i = 0; i < entry.Length; i++) 
    {
        if(entry[i].Length <= t) 
        {
            count++;
        }
    }
    return count;
}



