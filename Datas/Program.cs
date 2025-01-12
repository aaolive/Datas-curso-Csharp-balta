namespace Datas;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");

        var data = new DateTime();
        Console.WriteLine(data);

        var formato = "{0:yyyy-MM-dd}";

        Console.WriteLine(string.Format(formato, data)); // formata a data com o modelo de formato


        var data2 = DateTime.Now;
        Console.WriteLine(string.Format("{0:t}", data2)); // so tempo  :t

        var data3 = DateTime.Now;
        Console.WriteLine(string.Format("{0:d}", data3)); // so data  :d

        Console.WriteLine(string.Format("{0:T}", data3)); // so data  :T tempo longo
        Console.WriteLine(string.Format("{0:D}", data3)); // so data  :D data longa

        //formato de data universal
        Console.WriteLine(string.Format("{0:u}", data3)); // data universal do json

        Console.WriteLine(string.Format("{0:r}", data3)); // do javascript

        Console.WriteLine(string.Format("{0:s}", data3)); // do banco de dados mongo
    }
}
