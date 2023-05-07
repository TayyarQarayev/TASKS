
public class Film
{
    public string Name { get; set; }
    public string DirectorName { get; set; }
    public double ImdbScore;
    public double _ImdbScore
    {
        get { return ImdbScore; }
        set
        {
            if (ImdbScore < 2 && ImdbScore > 10)
            {
                Console.WriteLine("Imdb score is wrong!");
            }
            else
            {
                _ImdbScore = ImdbScore;
            }
        }
    }
    public string ReleaseDate { get; set; }
}
