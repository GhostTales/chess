public class Board
{

    Brik[,] tiles;

    public Board()
    {
        this.tiles = new Brik[8, 8];
    }

    public Brik pos(int x, int y)
    {
        return this.tiles[x, y];
    }

}