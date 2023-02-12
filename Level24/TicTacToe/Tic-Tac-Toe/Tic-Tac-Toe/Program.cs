using System.Globalization;

void Main()
{
    GameBoard board = new GameBoard();
    board.playGame();
}

Main();

class GameBoard
{
    public string[,] GameBoardArray { get; set; } = new string[3, 3]
    {
        { " ", " ", " " },
        { " ", " ", " " },
        { " ", " ", " " }
    };
    private string _playerTurn;
    public string PlayerTurn
    {
        get => _playerTurn;
        set
        {
            if (value == null)
                _playerTurn = "";
            else if (value.Length > 1)
                _playerTurn = "";
            else if (value != "X" && value != "O")
                _playerTurn = "";
            else
                _playerTurn = value;
        }
    }
    public (int, int) PlayerWins { get; set; } = (0, 0); //X and O wins
    public GameState CurrentGameState { get; set; } = GameState.Init;
    public string RoundWinner { get; set; } = "";
    public int CurrentRound { get; set; } = 0;
    public int NumRounds { get; set; } = 0;

    public GameBoard() {
        
    }

    public void playGame()
    {
        while (true)
        {
            switch (CurrentGameState) {
                case GameState.Init:
                    initGame();
                    break;
                case GameState.Running:
                    displayGame();
                    nextTurn();
                    checkRoundState();
                    break;
                case GameState.Draw:
                    displayGame();
                    break;
                case GameState.Winner:
                    displayGame();
                    break;
                case GameState.Complete:
                    displayGameResults();
                    break;
            }
        }
    }

    public void initGame()
    {
        Console.Clear();
        while (NumRounds == 0)
        {
            Console.WriteLine("Please enter the number of rounds for the game: ");
            NumRounds = Int32.Parse(Console.ReadLine());
        }

        Random random = new Random();
        int turnSelector = random.Next(1, 3);
        PlayerTurn = turnSelector switch
        {
            1 => "X",
            2 => "O",
            _ => "X"
        };

        CurrentGameState = GameState.Running;
    }

    public void nextTurn()
    {
        (int, int) boardOutput = validateInput();

        if (boardOutput.Item1 == -1 || boardOutput.Item2 == -1)
            return;

        GameBoardArray[boardOutput.Item1, boardOutput.Item2] = PlayerTurn;

        PlayerTurn = PlayerTurn switch
        {
            "X" => "O",
            "O" => "X",
            _ => "X"
        };
    }

    public (int, int) validateInput()
    {
        string turnInput = "";
        while (turnInput == "")
        {
            Console.WriteLine("Location: ");
            turnInput = Console.ReadLine();

            if (turnInput == null)
                turnInput = "";
            if (turnInput.Length != 1)
                turnInput = "";
            else
                if (!Char.IsNumber(turnInput[0]))
                    turnInput = "";
        }

        (int, int) boardPlacement = getBoardCoords(turnInput);

        if (boardPlacement.Item1 == -1 || boardPlacement.Item2 == -1)
            return (-1, -1);

        if (GameBoardArray[boardPlacement.Item1, boardPlacement.Item2] != " ")
            return (-1, -1);

        return (boardPlacement.Item1, boardPlacement.Item2);
    }

    //function returns true if round is finished
    public void checkRoundState()
    {
        bool emptyExists = false;
        string comparePiece = "";
        for(int i = 0; i < GameBoardArray.GetLength(0); i++)
        {
            for (int j = 0; j < GameBoardArray.GetLength(1); j++)
            {
                if (GameBoardArray[i, j] == " ")
                    emptyExists = true;

                comparePiece = GameBoardArray[i, j];
                if (comparePiece != " ")
                {
                    switch ((i, j))
                    {
                        case (0, 0):
                            if (GameBoardArray[i, j + 1] == comparePiece && GameBoardArray[i, j + 2] == comparePiece)
                                CurrentGameState = GameState.Winner;
                            if (GameBoardArray[i + 1, j] == comparePiece && GameBoardArray[i + 2, j] == comparePiece)
                                CurrentGameState = GameState.Winner;
                            if (GameBoardArray[i + 1, j + 1] == comparePiece && GameBoardArray[i + 2, j + 2] == comparePiece)
                                CurrentGameState = GameState.Winner;
                            break;
                        case (0, 1):
                            if (GameBoardArray[i + 1, j] == comparePiece && GameBoardArray[i + 2, j] == comparePiece)
                                CurrentGameState = GameState.Winner;
                            break;
                        case (0, 2):
                            if (GameBoardArray[i + 1, j] == comparePiece && GameBoardArray[i + 2, j] == comparePiece)
                                CurrentGameState = GameState.Winner;
                            break;
                        case (1, 0):
                            if (GameBoardArray[i, j + 1] == comparePiece && GameBoardArray[i, j + 2] == comparePiece)
                                CurrentGameState = GameState.Winner;
                            break;
                        case (2, 0):
                            if (GameBoardArray[i, j + 1] == comparePiece && GameBoardArray[i, j + 2] == comparePiece)
                                CurrentGameState = GameState.Winner;
                            if (GameBoardArray[i - 1, j + 1] == comparePiece && GameBoardArray[i - 2, j + 2] == comparePiece)
                                CurrentGameState = GameState.Winner;
                            break;
                        default:

                            break;
                    }
                }
            }
        }

        if (!emptyExists && CurrentGameState == GameState.Running)
            CurrentGameState = GameState.Draw;
        if(CurrentGameState == GameState.Winner)
        {
            RoundWinner = PlayerTurn switch
            {
                "X" => "O",
                "O" => "X",
                _ => ""
            };
            if (RoundWinner == "X")
                PlayerWins = (PlayerWins.Item1 + 1, PlayerWins.Item2);
            if (RoundWinner == "O")
                PlayerWins = (PlayerWins.Item1, PlayerWins.Item2 + 1);
            CurrentRound += 1;
        }
    }

    public void displayGame()
    {
        Console.Clear();
        if (CurrentGameState == GameState.Running)
        {
            Console.WriteLine($"Round {CurrentRound}/{NumRounds}");
            Console.WriteLine($"It is {PlayerTurn}'s turn.");
        }
        else if (CurrentGameState == GameState.Draw)
        {
            Console.WriteLine("The round ended in a draw");
            Console.WriteLine($"Round {CurrentRound}/{NumRounds}");
        }
        else if (CurrentGameState == GameState.Winner)
            Console.WriteLine($"Round {CurrentRound}/{NumRounds} - Round won by {RoundWinner}");

        displayBoard();

        Console.WriteLine("\n\nInstructions:");
        if (CurrentGameState == GameState.Running)
        {
            Console.WriteLine($"Enter a number for the corresponding position you'd like to mark an {PlayerTurn} in.  See below chart for guidelines");
            Console.WriteLine("7|8|9");
            Console.WriteLine("-+-+-");
            Console.WriteLine("4|5|6");
            Console.WriteLine("-+-+-");
            Console.WriteLine("1|2|3");
        }
        else if (CurrentGameState == GameState.Draw)
        {
            Console.WriteLine("Press any key to go to the next round");
            Console.ReadKey();
            resetGame(false);
        }
        else if (CurrentGameState == GameState.Winner)
        {
            if (CurrentRound < NumRounds) 
            {
                Console.WriteLine("Press any key to go to the next round");
                Console.ReadKey();
                resetGame(false);
            }
            else if(CurrentRound == NumRounds)
            {
                Console.WriteLine("Game complete, press any key to see results");
                CurrentGameState = GameState.Complete;
                Console.ReadKey();
            }
        }
    }

    public void displayGameResults()
    {
        Console.Clear();
        if (PlayerWins.Item1 > PlayerWins.Item2)
            Console.WriteLine("X won the game!");
        else if (PlayerWins.Item1 < PlayerWins.Item2)
            Console.WriteLine("O won the game!");
        else
            Console.WriteLine("The game ended in a draw!");
        Console.WriteLine($"X won {PlayerWins.Item1} times - O won {PlayerWins.Item2} times");

        Console.WriteLine("Press any key to play again.");
        Console.ReadKey();
        resetGame(true);
    }

    public void displayBoard()
    {
        Console.WriteLine($" {GameBoardArray[0, 0]} | {GameBoardArray[0, 1]} | {GameBoardArray[0, 2]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {GameBoardArray[1, 0]} | {GameBoardArray[1, 1]} | {GameBoardArray[1, 2]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {GameBoardArray[2, 0]} | {GameBoardArray[2, 1]} | {GameBoardArray[2, 2]} ");
    }

    public void resetGame(bool resetAll)
    {
        GameBoardArray = new string[3, 3]
        {
            { " ", " ", " " },
            { " ", " ", " " },
            { " ", " ", " " }
        };

        Random random = new Random();
        int turnSelector = random.Next(1, 3);
        PlayerTurn = turnSelector switch
        {
            1 => "X",
            2 => "O",
            _ => "X"
        };
        CurrentGameState = GameState.Running;

        RoundWinner = "";

        if (resetAll)
        {
            PlayerWins = (0, 0); //X and O wins
            CurrentRound = 0;
            NumRounds = 0;
            CurrentGameState = GameState.Init;
        }
    }

    public (int, int) getBoardCoords(string zInput)
    {
        return zInput switch
        {
            "1" => (2, 0),
            "2" => (2, 1),
            "3" => (2, 2),
            "4" => (1, 0),
            "5" => (1, 1),
            "6" => (1, 2),
            "7" => (0, 0),
            "8" => (0, 1),
            "9" => (0, 2),
            _ => (-1, -1)
        };
    }
}

enum GameState { Init, Running, Winner, Draw, Complete }