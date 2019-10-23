/*
 *  Both $@"..." and @$"..." are valid interpolated verbatim strings.
 *  In earlier C# versions, the $ token must appear before the @ token.
 */
 
 using System;

namespace EnhancementOfInterpolatedVerbatimStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = DateTime.Now.ToString();
            Console.WriteLine(@"C:\Windows\System32\cmd.exe " + dateTime);
            Console.WriteLine($"C:\\Windows\\System32\\cmd.exe {dateTime}");

            Console.WriteLine($@"C:\Windows\System32\cmd.exe {dateTime}");
            Console.WriteLine(@$"C:\Windows\System32\cmd.exe {dateTime}");
        }
    }
}
