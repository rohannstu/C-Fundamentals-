// LSP Violation Example
class Robot
{
    public string Name;
    public int PowerLevel;

    public virtual void Work()
    {
        Console.WriteLine("Robot is working !");
    }
}

class ShowpieceRobot : Robot
{
    public override void Work()
    {
        throw new Exception("This robot cannot work!");
    }
}
