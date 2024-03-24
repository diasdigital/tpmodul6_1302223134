using System.Diagnostics;

namespace tpmodul6_1302223134;

internal class SayaTubeVideo
{
    private int id;
    private String title;
    private int playCount;

    public SayaTubeVideo(String title)
    {
        Debug.Assert(title != null, "Judul tidak boleh kosong");
        Debug.Assert(title.Length <= 100, "Judul tidak boleh lebih dari 100 karakter");

        this.title = title;
        Random random = new Random();
        id = random.Next(10000,99999);
        playCount = 0;
    }

    public void IncreasePlayCount(int playCount)
    {
        Debug.Assert(playCount <= 10000000, "Penambahan play count maksimal 10.000.000 per panggilan method-nya");
        try
        {
            int newPlayCount = checked(this.playCount + playCount);
            this.playCount = newPlayCount;
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
        
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("ID\t\t: " + id);
        Console.WriteLine("Title\t\t: " + title);
        Console.WriteLine("Play Count\t: " + playCount);
    }
}
