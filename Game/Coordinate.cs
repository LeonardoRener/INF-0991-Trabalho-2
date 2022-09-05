public class Coordinate
{
    private int pos_x;
    private int pos_y;

    public Coordinate(int x, int y)
    {
        this.pos_x = x;
        this.pos_y = y;
    }

    public int getX()
    {
        return this.pos_x;
    }

    public int getY()
    {
        return this.pos_y;
    }

    private bool Compare(int x, int y)
    {
        return this.pos_x == x && this.pos_y == y;
    }
}