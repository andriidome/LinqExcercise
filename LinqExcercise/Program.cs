namespace LinqExcercise;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // 1
        Console.WriteLine(string.Join(",", Enumerable.Range(10, 41).ToArray()));

        // 2
        Console.WriteLine(string.Join(",", Enumerable.Range(10, 41).ToArray().Where(n => n % 3 == 0).ToArray()));

        // 3
        Console.WriteLine(string.Join(' ', Enumerable.Range(0, 10).ToList().Select(n => "LINQ").ToArray()));

        // 4
        string input4 = "aaa;abb;ccc;dap";
        Console.WriteLine(string.Join(',', input4.Split(";").Where(c => c.Contains('a')).ToArray()));

        // 5
        Console.WriteLine(string.Join(',', input4.Split(";").Select(s => s.Count(c => c == 'a')).ToArray()));
        Console.WriteLine(string.Join(',', input4.Split(";").Where(c => c.Contains('a')).Select(s => s.Count(c => c == 'a')).ToArray()));
        // 6
        string input6 = "aaa;xabbx;abb;ccc;dap";
        Console.WriteLine(input6.Split(";").Any(s => s == "abb"));

        // 7
        Console.WriteLine(
            (from word in input6.Split(";")
            where word.Length == input6.Split(";").Select(s => s.Length).Max()
            select word).First()
        );
        // 8
        Console.WriteLine(input6.Split(";").Select(s => s.Length).Average());

        // 9
        string input9 = "aaa;xabbx;abb;ccc;dap;zh";
        Console.WriteLine(
             string.Join("", (from word in input9.Split(";")
             where word.Length == input9.Split(";").Select(s => s.Length).Min()
             select word).First().Reverse().ToArray())
        );

        // 10
        string input10 = "baaa;aabb;aaa;xabbx;abb;ccc;dap;zh";
        Console.WriteLine(input10.Split(";").Where(s => s.StartsWith("aa")).First().ToArray().Skip(2).All(c => c == 'b'));


        // 11
        Console.WriteLine(input10.Split(";").Skip(2).Where(s => s.EndsWith("bb")).Last());
        
        Console.ReadLine();
    }
}

