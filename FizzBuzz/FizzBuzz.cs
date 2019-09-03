using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FizzBuzz
{
    class FizzBuzz:IFizzBuzz
    {
        private TextWriter _textWriter;

        public FizzBuzz(TextWriter textWriter)
        {
            _textWriter = textWriter;
        }

        public void PrintNumbers(int N)
        {
            for (int i = 1; i <= N; i++)
            {
               if (i % 15 == 0)
                {
                    _textWriter.Write("fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    _textWriter.Write("fizz");
                }
                else if (i % 5 == 0)
                {
                    _textWriter.Write("buzz");
                }
                else
                {
                    _textWriter.Write(i);
                }
                _textWriter.Write(" ");
            }
        }

    }
}
