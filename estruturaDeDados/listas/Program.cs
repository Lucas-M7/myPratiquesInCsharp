List<int> myList = new List<int>();
List<int> myNewList = new List<int> { 20, 30, 40, 50, 60, 70 };

myList.AddRange(myNewList);

int sum = 0;
for (int i = 0; i < myList.Count; i++)
{
    sum += myList[i];
}

Console.WriteLine(sum);