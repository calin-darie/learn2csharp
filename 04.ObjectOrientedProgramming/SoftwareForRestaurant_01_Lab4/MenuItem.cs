namespace SoftwareForRestaurant_01_Lab4
{
    internal class MenuItem
    {
        public string Name { get; set; }

        public virtual void printToScreen()
        { System.Console.Write($"{Name} - "); }
}
}