using System;

ChestState currentChestState = ChestState.Locked;

while (true)
{
    switch (currentChestState)
    {
        case ChestState.Open:
            Console.WriteLine("The chest is open, what do you want to do? ");
            break;
        case ChestState.Closed:
            Console.WriteLine("The chest is closed, what do you want to do? ");
            break;
        case ChestState.Locked:
            Console.WriteLine("The chest is locked, what do you want to do? ");
            break;
    }

    string actionInput = Console.ReadLine().ToLower().Trim();

    switch (actionInput)
    {
        case "unlock":
            if (currentChestState == ChestState.Locked)
                currentChestState = ChestState.Closed;
            else
                Console.WriteLine("Chest is already unlocked");
            break;
        case "lock":
            if (currentChestState == ChestState.Closed)
                currentChestState = ChestState.Locked;
            else if (currentChestState == ChestState.Open)
                Console.WriteLine("Chest is open");
            else
                Console.WriteLine("Chest is already locked");
            break;
        case "open":
            if(currentChestState == ChestState.Closed)
                currentChestState = ChestState.Open;
            else if(currentChestState == ChestState.Locked)
                Console.WriteLine("Chest is locked");
            else
                Console.WriteLine("Chest is already open");
            break;
        case "close":
            if (currentChestState == ChestState.Open)
                currentChestState = ChestState.Closed;
            else
                Console.WriteLine("Chest is already closed");
            break;
        default:
            Console.WriteLine("Invalid action");
            break;
    }
}

enum ChestState { Open, Closed, Locked };