namespace tpmodul6_1302223134;

internal class SayaTubeVideo
{
    private int id;
    private String title;
    private int playCount;

    public SayaTubeVideo(String title)
    {
        this.title = title;
        Random random = new Random();
        id = random.Next(10000,99999);
        playCount = 0;
    }

    public void IncreasePlayCount(int playCount)
    {
        this.playCount += playCount;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("ID\t\t: " + id);
        Console.WriteLine("Title\t\t: " + title);
        Console.WriteLine("Play Count\t: " + playCount);
    }
}
