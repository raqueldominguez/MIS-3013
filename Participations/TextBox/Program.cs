using System;

namespace TextBox
{
    class Program
    {
        static void Main(string[] args)
        {
            TextBox MyTextBox = new TextBox();

            MyTextBox.Padding = 5;
            MyTextBox.BackColor = ConsoleColor.Red;
            MyTextBox.ForeColor = ConsoleColor.White;
            MyTextBox.text = "Hello, world!";

            MyTextBox.DisplayText();

            MyTextBox.Padding = 15;
            MyTextBox.BackColor = ConsoleColor.Green;
            MyTextBox.ForeColor = ConsoleColor.Magenta;
            MyTextBox.text = "Happy Holidays!";

            MyTextBox.DisplayText();

            Console.ReadKey();
        }
    }
}
