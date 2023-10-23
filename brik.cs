public class Brik : Board
{

    protected string BrikName { get; }
    public bool Color { get; }
    private List<(int, int)>? MoveSet { get; }
    public List<(int, int)>? Moves { get; }

    private Brik(string Name, bool Color)
    {
        this.BrikName = Name;
        this.Color = Color;
    }

}


