

using System.Collections.Generic;
using System.Dynamic;

private class Brik
{

    public string Brickname;
    public int move;
    public string color;
    private List<(int, int)> moveset;
    public List<(int, int)> moves;




    public string Getbrickname()
    {

        return Brickname;


    }
  
    public int Getmove()
    {

        return move;

    }

    public string Getcolor()
    {
        return color;
    }


    public (int, int) Getmoves()
    {

        return moves;
    }


}


