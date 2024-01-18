using System.Linq;
using System;

List<int> NumberList = new List<int>(20);
Random random = new Random();
for (int i = 0; i < 20; i++)
{

    NumberList.Add(random.Next(1, 101));
}

var whereSubList = NumberList.Where(x => x > 8).ToList();

var maxNum = NumberList.Max(x => x);
var minNum = NumberList.Min(x => x);
var avgNum = NumberList.Average(x => x);

var selectSubList = NumberList.Select(x => x / 2);

var orderList = NumberList.OrderBy(x => x).ToList();

var SubList = NumberList.Take(5).ToList();

var AfterList = NumberList.Skip(5).ToList();

var checkEvenNum = NumberList.Any(x => x % 2 == 0);

var CheckAllEven = NumberList.All(x => x % 2 == 0);


foreach (int i in SubList)
{
    Console.WriteLine(i);
}
