using System.Collections.Generic;

namespace Geekbrains
{
    public sealed class ExampleUsing
    {
        // private int WriteLinesToFile(IEnumerable<string> lines)
        // {
        //     using var file = new System.IO.StreamWriter("WriteLines2.txt");
        //     // Notice how we declare skippedLines after the using statement.
        //     int skippedLines = 0;
        //     foreach (string line in lines)
        //     {
        //         if (!line.Contains("Second"))
        //         {
        //             file.WriteLine(line);
        //         }
        //         else
        //         {
        //             skippedLines++;
        //         }
        //     }
        //     // Notice how skippedLines is in scope here.
        //     return skippedLines;
        //     // file is disposed here
        // }
    }
}
