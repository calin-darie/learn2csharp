using System;

namespace _01_Restaurant
{
    class MenuItem
    {
        public string Name { get; set; }
        
        public virtual void printToScreen()
        {
        }

        const int beverageTextLength = 45;

        public static void centerText(String text, String itemName, int offset = beverageTextLength)
        {                      
            Console.Write(new string(' ', (Console.WindowWidth - offset) / 2 - itemName.Length));
            Console.WriteLine(text);

            
        }
    }
}
