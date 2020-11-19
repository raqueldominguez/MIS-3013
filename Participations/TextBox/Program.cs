using System;

namespace TextBox
{
    class Program
    {
        static void Main(string[] args)
        {
            TextBox MyTextBox = new TextBox();

            MyTextBox.Padding = 15;
            MyTextBox.BackColor = ConsoleColor.Red;
            MyTextBox.ForeColor = ConsoleColor.White;
            MyTextBox.text = "Hello, world!";

        }
    }
}
