using System;
using System.Collections.Generic;
using System.Text;

namespace TextBox
{
    class TextBox
    {
        public int Padding { get; set; }
        public ConsoleColor BackColor { get; set; }
        public ConsoleColor ForeColor { get; set; }
        public string text { get; set; }

        public TextBox()
        {
            Padding = 0;
            BackColor = default;
            ForeColor = default;
            text = string.Empty;
        }

        public void DisplayText()
        {
            Console.WriteLine(text.PadRight(Padding), BackColor, ForeColor);
        }
    }
}
