
using tic_tac_toe.Setup;



namespace tic_tac_toe.Logic
{
    public class Conditions
    {
        public static bool AllSquareIsOccupied(List<string> square)
        {
            if (SquareIsOccupied(square, 1) && SquareIsOccupied(square, 2) && SquareIsOccupied(square, 3) && SquareIsOccupied(square, 4)
                   && SquareIsOccupied(square, 5) && SquareIsOccupied(square, 6) && SquareIsOccupied(square, 7) && SquareIsOccupied(square, 8) &&
                   SquareIsOccupied(square, 9))
                return true;

            return false;
        }


        public static bool SquareIsOccupied(List<string> square, int squareIndex)
        {
            if (square[squareIndex] != "O" && square[squareIndex] != "X")
                return false;
            return true;
        }

        public static bool HasWon(List<string> square, string player)
        {
            if (square[1] == player && square[2] == player && square[3] == player)
                return true;
            if (square[4] == player && square[5] == player && square[6] == player)
                return true;
            if (square[7] == player && square[8] == player && square[9] == player)
                return true;
            if (square[1] == player && square[4] == player && square[7] == player)
                return true;
            if (square[2] == player && square[5] == player && square[8] == player)
                return true;
            if (square[3] == player && square[6] == player && square[9] == player)
                return true;
            if (square[1] == player && square[5] == player && square[9] == player)
                return true;
            if (square[3] == player && square[5] == player && square[7] == player)
                return true;


            return false;

        }


        public static bool Draw(List<string> square)
        {
            if (!HasWon(square, Game.X) && !HasWon(square, Game.O) && AllSquareIsOccupied(square))
                return true;
            return false;
        }





        public static int ValidateNumber(int number)
        {

            while (number > 9 || number < 1)
            {
                Console.Write("Invalid number, please choose in range 1-9:  ");
                string? answer = Console.ReadLine();


                while (!int.TryParse(answer, out number))
                {
                    Console.Write("Please use numbers: ");
                    answer = Console.ReadLine();
                }

            }
           
            return number;


        }
    }
}
