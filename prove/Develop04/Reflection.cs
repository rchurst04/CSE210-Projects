using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string> { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult." };
    private List<string> _questions = new List<string> { "Why was this experience meaningful to you?", "Have you ever done anything like this before?" };

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.") { }

    public void Run()
    {
        Start();
        Console.WriteLine("\n--- " + _prompts[new Random().Next(_prompts.Count)] + " ---\n");
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> " + _questions[new Random().Next(_questions.Count)] + " ");
            ShowSpinner(5);
            Console.WriteLine();
        }
        End();
    }
}
