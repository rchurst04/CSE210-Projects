class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("10 Cooking Hacks You Need to Know", "ChefMike", 540);
        video1.AddComment("FoodLover99", "These hacks changed my life!");
        video1.AddComment("CookingNovice", "I tried the egg hack and it worked perfectly.");
        video1.AddComment("KitchenQueen", "Number 7 blew my mind.");

        // Video 2
        Video video2 = new Video("Learn C# in 30 Minutes", "CodeWithTom", 1820);
        video2.AddComment("DevBeginner", "Finally a tutorial that makes sense!");
        video2.AddComment("SeniorDev", "Great intro, wish you covered interfaces too.");
        video2.AddComment("StudentCoder", "Watched this three times for my class.");
        video2.AddComment("JavaConvert", "Coming from Java, this helped a lot.");

        // Video 3
        Video video3 = new Video("Hiking the Grand Canyon Rim to Rim", "AdventureAmy", 2340);
        video3.AddComment("TrailBlazer", "Did this last summer, amazing experience!");
        video3.AddComment("HikingNewbie", "How fit do you need to be to do this?");
        video3.AddComment("NaturePhotog", "The footage at mile 9 was breathtaking.");

        // Video 4
        Video video4 = new Video("Budget Travel Tips for Europe", "WanderWise", 980);
        video4.AddComment("BackpackerBob", "Saved so much money using tip #3.");
        video4.AddComment("EuroTrip2024", "Booking cheap trains was a game changer.");
        video4.AddComment("TravelSmart", "Great video, very practical advice.");

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}
