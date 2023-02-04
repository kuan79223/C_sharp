
//new 運算子會建立型別的新執行個體。
//您也可以使用 new 關鍵字作為成員宣告修飾詞或泛型型別條件約束。


//若要建立型別的新執行個體，您通常會使用 new 運算子叫用該型別的其中一個建構函式：
// variables 變量
var dict = new Dictionary<string, int>();

dict["first"] = 1;
dict["second"] = 2;
dict["third"] = 3;

Console.WriteLine(string.Join("; ",dict.Select(entry => $"{entry.Key}: {entry.Value}")));

//使用物件或集合初始設定式，用大括號在單一陳述式中具現化和初始化物件:

var dict1 = new Dictionary<string, int>()
{   ["first"] = 10, 
    ["second"] = 20, 
    ["third"] = 30
};

Console.WriteLine(string.Join("; ",dict1.Select(entry=>$"{entry.Key}: {entry.Value}")));


List<int> xs = new();
List<int> ys = new(capacity: 10_000);
List<int> zs = new() { Capacity = 20_000 };

Dictionary<int, List<int>> lookup = new()
{
    [1] = new() { 1, 2, 3 },
    [2] = new() { 5, 8, 3 },
    [5] = new() { 1, 0, 4 }
};

Console.WriteLine(string.Join("; ", lookup.Select(entry => $"{entry.Key}: {entry.Value}")));
