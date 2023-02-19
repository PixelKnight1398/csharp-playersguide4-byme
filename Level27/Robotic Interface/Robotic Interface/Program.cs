using System.Security.Cryptography.X509Certificates;

void Main()
{
    IRobotCommand[] commandInputs = new IRobotCommand[3];

    Console.WriteLine("Please enter a command for the robot:");
    Console.WriteLine("[1] Power On");
    Console.WriteLine("[2] Power Off");
    Console.WriteLine("[3] Move North");
    Console.WriteLine("[4] Move South");
    Console.WriteLine("[5] Move East");
    Console.WriteLine("[6] Move West");

    for (int i = 0; i < 3; i++)
    {
        string commandTextInput = Console.ReadLine();
        commandInputs[i] = commandTextInput switch
        {
            "1" => new OnCommand(),
            "2" => new OffCommand(),
            "3" => new NorthCommand(),
            "4" => new SouthCommand(),
            "5" => new EastCommand(),
            "6" => new WestCommand()
        };
    }

    Robot deployedRobot = new Robot(0, 0, false, commandInputs);
    deployedRobot.Run();
}

Main();

public class Robot
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsPowered { get; set; }
    public IRobotCommand[] Commands { get; } = new IRobotCommand[3];

    public Robot(int x, int y, bool isPowered, IRobotCommand[] commands)
    {
        X = x;
        Y = y;
        IsPowered = isPowered;
        Commands = commands;
    }

    public void Run()
    {
        foreach (IRobotCommand command in Commands)
        {
            command.Run(this);
            Console.WriteLine($"[{X} {Y} {IsPowered}]");
        }
    }
}

public interface IRobotCommand
{
    void Run(Robot robot);
}

public class OnCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        robot.IsPowered = true;
    }
}

public class OffCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        robot.IsPowered = false;
    }
}

public class NorthCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered)
            robot.Y += 1;
    }
}

public class SouthCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered)
            robot.Y -= 1;
    }
}

public class WestCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered)
            robot.X -= 1;
    }
}

public class EastCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered)
            robot.X += 1;
    }
}