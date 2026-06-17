using System;
using System.Collections.Generic;
using System.IO;

// 1. DATA CLASS: Stores the details for a single entry
public class Entry {
    public string Date;
    public string Prompt;
    public string Response;

    public void Display() {
        Console.WriteLine($"Date: {Date} - Prompt: {Prompt}\nResponse: {Response}\n");
    }
}

// 2. MANAGEMENT CLASS: Handles the list and file operations
public class Journal {
    public List<Entry> entries = new List<Entry>();

    public void SaveToFile(string filename) {
        using (StreamWriter sw = new StreamWriter(filename)) {
            foreach (var e in entries) 
                sw.WriteLine($"{e.Date}|{e.Prompt}|{e.Response}");
        }
    }

    public void LoadFromFile(string filename) {
        entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines) {
            string[] parts = line.Split('|');
            entries.Add(new Entry { Date = parts[0], Prompt = parts[1], Response = parts[2] });
        }
    }
}

// 3. INTERFACE CLASS: Runs the main menu and user interaction
class Program {
    static void Main() {
        Journal journal = new Journal();
        string[] prompts = { "What was the best part of my day?", "What did I learn today?" };
        bool running = true;

        while (running) {
            Console.WriteLine("1. Write, 2. Display, 3. Save, 4. Load, 5. Quit");
            string choice = Console.ReadLine();

            if (choice == "1") {
                Entry entry = new Entry { 
                    Date = DateTime.Now.ToShortDateString(),
                    Prompt = prompts[new Random().Next(prompts.Length)],
                    Response = Console.ReadLine() 
                };
                journal.entries.Add(entry);
            } 
            else if (choice == "2") journal.entries.ForEach(e => e.Display());
            else if (choice == "3") journal.SaveToFile("journal.txt");
            else if (choice == "4") journal.LoadFromFile("journal.txt");
            else if (choice == "5") running = false;
        }
    }
}
