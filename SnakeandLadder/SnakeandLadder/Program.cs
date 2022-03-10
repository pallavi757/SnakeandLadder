public class SnakesAndLadders
{

     public static void Main(String[] args)

	  {
        Console.WriteLine("Welcome to Snake and Ladder game");

        int position = 0;
        int Roll = 0;
        Random random = new Random();
        int RollDie = random.Next(1, 6);//To get number between 1 to 6
        Random CheckOption=new Random();
        Console.WriteLine("The dice was rolled to: " + RollDie);
        int NoPlay_Ladder_Snake=CheckOption.Next(0,3);
        while (position < 100)
        {
            switch (NoPlay_Ladder_Snake)
            {
                case 0:
                    Console.WriteLine("Player action: nothing");
                    break;
                case 1:
                    Console.WriteLine("Player action: ladder");
                    position += RollDie;
                    if (position > 100)
                    {
                        position -= RollDie;
                        Console.WriteLine(" Exceeded 100 so not counting");
                    }
                        break;
                case 2:
                    Console.WriteLine("Player action: snake");
                    position -= RollDie;
                    position = position < 0 ? 0 : position;//Using Conditinal operator
                    break;


            }
            Console.WriteLine("Current position: " + position);
            Roll++;
            Console.WriteLine(" Congratulations!! You took " + Roll + " rolls to win the game!!");
        }
       
        
      }
}

