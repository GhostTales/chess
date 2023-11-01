public abstract class Brik : Board
{

    protected string BrikName { get; }
    public bool Color { get; }
    public List<(int, int)>? MoveSet { get; }
    public List<(int, int)>? Moves { get; }

    private Brik(string Name, bool Color)
    {
        this.BrikName = Name;
        this.Color = Color;
    }

}


