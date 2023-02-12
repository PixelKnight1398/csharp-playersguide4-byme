using System.Security.Cryptography.X509Certificates;

void Main()
{
    Console.WriteLine("Creating a door");

    string passcodeInput = Door.InputPasscode();

    Door door = new Door(passcodeInput);

    while (true)
    {
        switch (door.DoorState)
        {
            case LockingDoorState.Open:
                Console.WriteLine("The door is open, what do you want to do? ");
                break;
            case LockingDoorState.Closed:
                Console.WriteLine("The door is closed, what do you want to do? ");
                break;
            case LockingDoorState.Locked:
                Console.WriteLine("The door is locked, what do you want to do? ");
                break;
        }

        Console.WriteLine("1 - Open");
        Console.WriteLine("2 - Close");
        Console.WriteLine("3 - Lock");
        Console.WriteLine("4 - Unlock");
        Console.WriteLine("5 - Reset Code");

        string doorstateInputString = Console.ReadLine();

        door.UpdateDoorState(doorstateInputString);
    }
}

Main();

class Door
{
    public string DoorCode { get; set; }
    public LockingDoorState DoorState { get; set; }

    public Door(string doorCode)
    {
        DoorCode = doorCode;
        DoorState = LockingDoorState.Locked;
    }

    public static string InputPasscode()
    {
        Console.WriteLine("Please enter a valid, 4 digit passcode:");
        string requestedCode = "";
        bool rulesPassed = false;

        while (!rulesPassed)
        {
            requestedCode = Console.ReadLine().Trim();

            if (requestedCode.Length != 4)
            {
                continue;
            }

            for (int i = 0; i < requestedCode.Length; i++)
            {
                char testChar = requestedCode[i];
                if (!Char.IsNumber(testChar))
                {
                    continue;
                }
            }

            rulesPassed = true;
        }

        return requestedCode;
    }

    public void UpdateDoorState(string doorStateInput)
    {
        string doorcodeInput = "";
        switch (doorStateInput)
        {
            case "1": //open
                if (DoorState == LockingDoorState.Open)
                    Console.WriteLine("Door is already open");
                else if (DoorState == LockingDoorState.Locked)
                    Console.WriteLine("Door is locked");
                else
                    DoorState = LockingDoorState.Open;
                break;
            case "2": //close
                if (DoorState != LockingDoorState.Open)
                    Console.WriteLine("Door is already closed");
                else
                    DoorState = LockingDoorState.Closed;
                break;
            case "3": //lock
                if (DoorState == LockingDoorState.Locked)
                    Console.WriteLine("Door is already locked");
                else if (DoorState == LockingDoorState.Open)
                    Console.WriteLine("Door is open");
                else
                    DoorState = LockingDoorState.Locked;
                break;
            case "4": //unlock
                if (DoorState != LockingDoorState.Locked)
                    Console.WriteLine("Door is already unlocked");
                else
                {
                    Console.WriteLine("Please input door code");
                    doorcodeInput = Door.InputPasscode();
                    if (doorcodeInput != DoorCode)
                        Console.WriteLine("Incorrect code");
                    else
                        DoorState = LockingDoorState.Closed;
                }
                break;
            case "5": //reset
                Console.WriteLine("To reset code, please input door code");
                doorcodeInput = Door.InputPasscode();

                if(doorcodeInput != DoorCode)
                    Console.Write("Incorrect code");
                else
                {
                    Console.WriteLine("Enter new code:");
                    doorcodeInput = Door.InputPasscode();
                    DoorCode = doorcodeInput;
                    Console.WriteLine("Code updated");
                }
                break;
            default:
                Console.WriteLine("Please use a valid input");
                break;
        }
    }
}

enum LockingDoorState { Open, Closed, Locked }