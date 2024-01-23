using System.Collections;

int[] arr = { 1, 1, 2, 5, 5, 6, 7, 333, 333, 0 };
Dictionary<int,int> map = new Dictionary<int,int>();
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (map.ContainsKey(arr[i]))
    {
        map[arr[i]]++;
    }
    else
    {
        map.Add(arr[i], 1);
    }
}

foreach(KeyValuePair<int,int> pair in map)
{
    if(pair.Value > 1) { count++; }
}

Console.WriteLine(count);



