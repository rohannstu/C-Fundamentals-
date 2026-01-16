class Program
{
    static void Main(string[] args)
    {
        Robot robot = new Robot { Name = "WorkerBot", PowerLevel = 100 };
        robot.Work();

        Robot showpieceRobot = new ShowpieceRobot { Name = "ShowBot", PowerLevel = 0 };
        try
        {
            showpieceRobot.Work();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
