namespace TestSoccerPlayer;

class Program
{
    static void Main(string[] args)
    {
        SoccerPlayer soccerPlayer = new SoccerPlayer();
        soccerPlayer.Name = "Messi";
        soccerPlayer.JerseyNumber = 10;
        soccerPlayer.Goals = 400;
        soccerPlayer.Assist = 100;

        Console.WriteLine(" Name: {0}\n JerseyNumber: {1}\n Goals: {2}\n Assists: {3}\n",
            soccerPlayer.Name, soccerPlayer.JerseyNumber, soccerPlayer.Goals, soccerPlayer.Assist);
    }
}

class SoccerPlayer {
    //generally should not be public
    public string Name { get; set; }

    // the above performsthe following
    //public string getName() { return name; }
    //public void setName() { name = name; }


    public int JerseyNumber { get; set; }
    public int Goals { get; set; }
    public int Assist { get; set; }

}

