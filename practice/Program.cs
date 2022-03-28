using System;
using ConsoleTables;
class Program
{
    static void Main(string[] args)
    {
        var table = new ConsoleTable("one", "two", "three", "four");
        table.AddRow(1, 2, 3, 4)
             .AddRow("this line should be longer", "yes it is", "oh", "=)");
        table.Write(Format.Alternative);
        //Console.WriteLine();

    }
}

