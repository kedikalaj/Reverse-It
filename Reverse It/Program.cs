using System;

class Program
{

    static public void Main(String[] args)
    {
        int[] sortedArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        bool unsorted=true;
        bool resume = true;

        Console.WriteLine("\nReverse It! v1.0");

        while (resume)
        {
            try
            {


                Console.WriteLine("\n1: Start new game \n2:Exit\n");
                Console.Write(">");
                int operationAnswer = Convert.ToInt32(Console.ReadLine());

                switch (operationAnswer)
                {
                    case 1:
                        int[] gameplayArray = generateRandomArr();
                        int nrMoves = 0;
                        while (unsorted)
                        {
                            

                                if (Enumerable.SequenceEqual(sortedArr, gameplayArray))
                                {
                                    unsorted=false;
                                    Console.WriteLine("\nGG WP");
                                Console.WriteLine($"You completed the game with {nrMoves} moves");
                                break;
                                }

                            try
                            {
                                Console.WriteLine("\nWhere you want to reverse the numbers?");
                                Console.Write(">");
                                int Answer0 = Convert.ToInt32(Console.ReadLine());
                                Console.Write("\n");
                                if (Answer0<=0 || Answer0 > 9)
                                {
                                    throw new ArgumentException();
                                }

                                int[] tempArray = new int[Answer0];

                                if (Answer0!=1) { 
                                for (int i = 0; i<Answer0; i++)
                                {
                                    
                                    tempArray[i] = gameplayArray[Answer0-i-1];
                                        
                                }

                                

                                for (int i = 0; i < Answer0; i++)
                                {
                                    
                                    gameplayArray[i] = tempArray[i];
                                        
                                    }

                                }
                                nrMoves++;

                                foreach (int i in gameplayArray)
                                {
                                    Console.Write(i+" ");
                                }
                                Console.WriteLine("");

                            }
                            catch (ArgumentException e)
                            {
                                Console.WriteLine("Please insert only numbers from 1 to 9");
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine("\nPlease insert only int numbers (1 or 2)");
                                resume = true;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                resume = false;
                            }


                            

                        }






                        break;
                    case 2:
                        resume = false;
                        break;
                        default:
                        throw new ArgumentException();
                        


                }



            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Please insert only 1 or 2");
            }
            catch (FormatException e)
            {
                Console.WriteLine("\nPlease insert only int numbers (1 or 2)");
                resume = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                resume = false;
            }


        }



    }


    static int[] generateRandomArr()
    {
        int[] randomArray = new int[9];
        Random random = new Random();

        for (int i = 0; i <= randomArray.Length - 1; i++)
        {
            var number = random.Next(1, 10);
            while (randomArray.Any(n => n == number))
            {
                number = random.Next(1, 10);
            }

            randomArray[i] = number;
            Console.Write(randomArray[i] + " ");
        }

        return randomArray;
    }



}