using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    public void Run()
    {
        Start();
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine("--- Who are people that you appreciate? ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }
        Console.WriteLine($"You listed {items.Count} items!");
        End();
    }
}
