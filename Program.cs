using System;

namespace Yahtzee
{
    class MainClass
    {
        
        public class FiveDice
        {
            
            //create 6 random dice and print their values

           
            public void RollDice()
            {

                Random rand = new Random();
                int randomOne = rand.Next(1, 6);
                int randomTwo = rand.Next(1, 6);
                int randomThree = rand.Next(1, 6);
                int randomFour = rand.Next(1, 6);
                int randomFive = rand.Next(1, 6);

                int[] yourDice = { randomOne, randomTwo, randomThree, randomFour, randomFive };

                for (var i = 0; i < yourDice.Length; i++)
                {
                    Console.WriteLine(yourDice[i]);
                }

            }
            

        }


        public class Game : FiveDice
        {

            public void Select()
            {
                {
                    Console.WriteLine("From your first roll, please select which dice you want to roll again: ");
                    var response = Console.ReadLine();

                    //Console.WriteLine(FiveDice.hello);
                    switch (response)
                    {
                        case 1:
                            // code block
                            break;
                        case 2:
                            // code block
                            break;
                        case 3:
                            // code block
                            break;
                        case 4:
                            // code block
                            break;
                        case 5:
                            // code block
                            break;
                        default:
                            // code block
                            break;
                    }
                }
            }

        }

        public static void Main(string[] args)
        {

            FiveDice dice = new FiveDice();
            dice.RollDice();

           

            Game game = new Game();
            game.Select();

            
           
        }
    }
}
