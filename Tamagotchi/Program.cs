using System.Drawing;
using Tamagotchi;
using CustomNS;

Egg egg;
egg = new Egg(ConsoleColor.Yellow, "Null"); //Tama!

//SetCursorPosition(X, Y);
int X = 10;
int Y = 0;

//Variables included in GameState.ColorSelection
ConsoleKeyInfo UserInput;
int Choice = 0; //For User Input - See "ColorSelect"

//Variables included in GameState.
int IsEgg = 0; //How long Tama stays an Egg.
int Pets = 0; //How many times Petted - Decides which Tama you get.


ConsoleColor[] Colors = {  //Colors available, for the Egg / Tama
    ConsoleColor.White,
    ConsoleColor.Magenta,
    ConsoleColor.Cyan,
    ConsoleColor.Red,
    ConsoleColor.Blue,
    ConsoleColor.Yellow,
    ConsoleColor.DarkMagenta,
    ConsoleColor.Green };

GameState State = GameState.Intro; // What State the game is in. 



void Intro()
{
    Console.Clear();

    Console.ForegroundColor = ConsoleColor.White;
    Console.SetCursorPosition(10, 0);

    Console.WriteLine("*** Welcome to a Tamagotchi game! ***");
    Console.SetCursorPosition(15, 1);

    Console.WriteLine("Press Any Button to Start!");
    Console.ReadKey();
    Console.Clear();
}

void ErrorWithColorSelection()
{
    Console.SetCursorPosition(X, Y + 1);
    Console.Write("Oops! Something went wrong. There are only 8 Available colors.");
    Console.SetCursorPosition(X, Y + 2);
    Console.Write("Please select a color, by their given number - from 1 to 8!");
}
void CorrectColorSelection()
{
    Choice -= 1;
    State = GameState.Petting;
}


void CheckingColorSelect(char UserInput)
{
    Console.SetCursorPosition(X, Y - 1);
    cText.ClearConsAt(X, Y, 100, Y + 10);

    if (char.IsDigit(UserInput)) //If User input is a number, and not a letter.
    {
        Choice = int.Parse(UserInput.ToString());
        if (Choice > 8 && Choice != 0) //Too high! User input is not a valid number.
        {
            ErrorWithColorSelection();
            Console.SetCursorPosition(X, Y - 1);
            CheckingColorSelect(Console.ReadKey().KeyChar);
        }
        else //If User input is a valid number.
        {
            CorrectColorSelection();
        }
    }
    else //If User input is a letter - Resets to choice.
    {
        ErrorWithColorSelection();
        Console.SetCursorPosition(X, Y - 1);
        CheckingColorSelect(Console.ReadKey().KeyChar);

    }
}

void ColorSelect()
{

    Console.SetCursorPosition(10, 0);
    Console.WriteLine("Which Color, would you like your Egg to be?");
    Y++;
    Console.SetCursorPosition(10, Y);
    Console.WriteLine("Please pick a color, by their given number!");
    Y += 2;
    foreach (var item in Colors) //Writes each Colour out in name, and corresponding color.
    {
        Console.ForegroundColor = item;
        Console.SetCursorPosition(X, Y);
        Y++;
        Console.WriteLine(item);
    }
    Console.ForegroundColor = ConsoleColor.White; //Resets font color to white!

    Y++;
    Console.SetCursorPosition(X, Y);
    Y++;

    do //Checks what color the User has selected, and if it's valid.
    {
        //if (UserInput.KeyChar > 49 && UserInput.KeyChar < 56) //If User input is a number, and not a letter.

        CheckingColorSelect(Console.ReadKey().KeyChar);

    } while (State == GameState.ColorSelection);
}
void EggPetting()
{
    do
    {
        do //Do-While, Shows the Egg/Tama shaking + Counts how old the Egg is
        {
            Console.Clear();
            egg.Shake();
            Thread.Sleep(2000);
            Console.SetCursorPosition(47, 3);
            Console.WriteLine("Would you like to pet the egg?");
            Console.SetCursorPosition(47, 5);
            Console.WriteLine("Yes [Y] / No [N] ?");
            Console.SetCursorPosition(47, 7);
            if (Console.ReadKey().Key == ConsoleKey.Y) //If Statement, checking how many times the Tama has been petted
            {
                Console.SetCursorPosition(47, 9);
                Console.WriteLine("*Rustle* *Rustle*");
                Thread.Sleep(1000);
                Pets++;
            }
            IsEgg++;
        } while (IsEgg <= 4);
        State = GameState.Transform;
    } while (State == GameState.Petting);
}



//---MAIN---


//do
//{
//    do
//    {
//        Console.WriteLine("press 1 to continue : ");
//        if (Console.ReadKey().KeyChar == '1')
//        {
//            State = GameState.ColorSelection;
//        }

//    } while (State == GameState.ColorSelection);

//    do
//    {

//    } while (State == GameState.Game);

//    do
//    {

//    } while (State == GameState.Dead);
//} while (State != GameState.Exit);


Console.CursorVisible = false;
Intro();
ColorSelect();
EggPetting();












