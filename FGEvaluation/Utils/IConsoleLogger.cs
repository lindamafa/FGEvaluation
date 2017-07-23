using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public interface IConsoleLogger
    {
        void WriteLine(string input);
        string Prompt(string input);
        string ReadLine();
    }

    public class ConsoleLogger
        : IConsoleLogger
    {
        public string Prompt(string input)
        {
            Console.WriteLine(input);
            return Console.ReadLine();
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void WriteLine(string input)
        {
            Console.WriteLine(input);
        }
    }
}
