
namespace _c_sharp_
{
    class Program
    {
        //class Point
        //{
        //    static int count;
        //    static Point(){
        //        count = 0;
        //    }
        //    private int xCoord;

        //    public int XCoord
        //    {
        //        get { return xCoord; }
        //        set { this.xCoord = (value >= 0) ? value : 0; }
        //    }
        //    public string Name { get; set; }
        //    private int yCoord;
        //    public int YCoord
        //    {
        //        get { return yCoord; }
        //        set { this.yCoord = (value >= 0) ? value : 0; }
        //    }
        //    public Point() : this(0, 0) { }
        //    public Point(int value) : this(value, value) { }
        //    public Point(int xCoord,int yCoord)
        //    {
        //        XCoord=xCoord;
        //        YCoord=yCoord;

        //        Name = "Name";
        //        this.yCoord = yCoord;
        //        count++;
        //    }
        //    public int getXCoord()
        //    {
        //        return xCoord;
        //    }
        //    public int getYCoord() {
        //        return yCoord;
        //    }
        //    public void setCoord(int newX)
        //    {
        //      this.xCoord = (newX>=0)?newX:0;
        //    }
        //    public void Print()
        //    {
        //        Console.WriteLine($"X: {xCoord}. Y: {yCoord}");
        //    }
        //}

        static void Main(string[] args)
        {
            Freezer[] freezers = new Freezer[5];
            freezers[0] = new Freezer();
            freezers[1] = new Freezer(10);
            freezers[2] = new Freezer(200,55,150,3,"white");
            freezers[3] = new Freezer(180, 50, 130, 2, "grey");
            freezers[4] = new Freezer(144, 52, 135, 3, "black");
            for(int i = 0; i < freezers.Length; i++)
            {
                Console.WriteLine(freezers[i].ToString());
            }

        }
    }
}