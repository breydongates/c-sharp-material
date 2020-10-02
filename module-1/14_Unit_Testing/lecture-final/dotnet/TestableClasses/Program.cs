using System;

namespace TestableClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MenuItem item = new SaveMenuItem();
            item.Execute();
            
        }
    }


    public abstract class MenuItem
    {
        public abstract string Name { get; }

        public virtual bool CanExecute { get; }

        public abstract void Execute();

        public void OnLoaded()
        {
            // Logic that happens for every menu item
        }
    }

    public class SaveMenuItem : MenuItem
    {
        public override string Name
        {
            get 
            {
                return "Save";
            }
        }

        public override void Execute()
        {
            // Save all the things
        }
    }







}
