class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();

        // Lecture
        Address lectureAddress = new Address("100 University Ave", "Rexburg", "ID", "USA");
        Lecture lecture = new Lecture(
            "Introduction to Artificial Intelligence",
            "A beginner-friendly talk on how AI is changing the world.",
            "15 Aug 2026",
            "6:00 PM",
            lectureAddress,
            "Dr. Sarah Mitchell",
            200
        );

        // Reception
        Address receptionAddress = new Address("500 Grand Ballroom Dr", "Salt Lake City", "UT", "USA");
        Reception reception = new Reception(
            "Annual Tech Networking Night",
            "Meet and greet with local tech professionals and entrepreneurs.",
            "22 Aug 2026",
            "7:00 PM",
            receptionAddress,
            "rsvp@technightslc.com"
        );

        // Outdoor Gathering
        Address outdoorAddress = new Address("1 Park Blvd", "Denver", "CO", "USA");
        OutdoorGathering outdoorGathering = new OutdoorGathering(
            "Summer Music Festival",
            "A free outdoor concert featuring local bands and food vendors.",
            "30 Aug 2026",
            "4:00 PM",
            outdoorAddress,
            "Sunny, 78°F, light breeze"
        );

        events.Add(lecture);
        events.Add(reception);
        events.Add(outdoorGathering);

        foreach (Event e in events)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("--- Standard Details ---");
            Console.WriteLine(e.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine("--- Full Details ---");
            Console.WriteLine(e.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine("--- Short Description ---");
            Console.WriteLine(e.GetShortDescription());
            Console.WriteLine();
        }
    }
}
