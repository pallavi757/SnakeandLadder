public class SnakesAndLadders
{

     public static void Main(String[] args)

	  {
        Console.WriteLine("Welcome to Snake and Ladder game");

        int position = 0;
        Random random = new Random();
        int RollDie = random.Next(1, 6);//To get number between 1 to 6
        Random CheckOption=new Random();
        Console.WriteLine("The dice was rolled to: " + RollDie);
        int NoPlay_Ladder_Snake=CheckOption.Next(0,3);
        switch(NoPlay_Ladder_Snake)
        {
            case 0:
                Console.WriteLine("Player action: nothing");
            break;
            case 1:
                Console.WriteLine("Player action: ladder");
                position += RollDie;
                break;
            case 2:
                Console.WriteLine("Player action: snake");
                position-=RollDie;
                break;


        }
        Console.WriteLine("Current position: " + position);
       
        
      }
}

