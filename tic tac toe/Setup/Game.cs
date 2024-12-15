
using tic_tac_toe.Logic;



namespace tic_tac_toe.Setup
{
    public class Game
    {
        

        public static string X { get; } = "X";
        public static string O { get; } = "O";

        public List<string> squares = new List<string>() { " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };



       

        
        public bool O_TurnToPlay = true;
        public void ChooseSquare(List<string> square, int number)
        {

            

            number = Conditions.ValidateNumber(number);



            while (Conditions.SquareIsOccupied(square, number))
            {
                Console.Write("Square is occupied, try another! ");
                string? answer = Console.ReadLine();


                while (!int.TryParse(answer, out number))
                {
                    Console.Write("Please use numbers: ");
                    answer = Console.ReadLine();
                }



                number = Conditions.ValidateNumber(number);
                Console.WriteLine();
            }

            if(O_TurnToPlay)
            {
               square[number] = O;
               GetBoard();
               O_TurnToPlay = false;
            }
            else if(!O_TurnToPlay)
            {
                square[number] = X;
                GetBoard();
                O_TurnToPlay = true;
            }



            if (Conditions.HasWon(square, "O"))
            {
                Console.WriteLine();
                Console.WriteLine("O won!");

            }


            if (Conditions.HasWon(square, "X"))
            {
                Console.WriteLine();
                Console.WriteLine("X won!");
            }


            if (Conditions.Draw(square))
            {
                Console.WriteLine();
                Console.WriteLine("It's a draw!");

            }


        }



        
        public void Run()
        {
            while (true)
            {

                Console.Write($"It's {O}-s turn to play, which square do you want to choose? ");
                string? answer = Console.ReadLine();
                int result;
                while (!int.TryParse(answer, out result))
                {
                    Console.Write("Please use numbers: ");
                    answer = Console.ReadLine();
                }

                Console.WriteLine();

                ChooseSquare(squares, result);
                if (Conditions.HasWon(squares, O) || Conditions.Draw(squares))
                    break;






                Console.Write($"It's {X}-s turn to play which square do you want to play? ");
                answer = Console.ReadLine();


                while (!int.TryParse(answer, out result))
                {
                    Console.Write("Please use numbers: ");
                    answer = Console.ReadLine();
                }

                Console.WriteLine();


                ChooseSquare(squares, result);
                if (Conditions.HasWon(squares, X) || Conditions.Draw(squares))
                    break;

            }

        }




        public void GetBoard()
        {
            Console.WriteLine($" {squares[1]}  | {squares[2]}  | {squares[3]} ");
            Console.WriteLine(" ---+----+---");
            Console.WriteLine($" {squares[4]}  | {squares[5]}  | {squares[6]} ");
            Console.WriteLine(" ---+----+---");
            Console.WriteLine($" {squares[7]}  | {squares[8]}  | {squares[9]} ");
        }
    }
}
