using System;

namespace HigherOrLower
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cardSuit = { "hearts", "diamonds", "clubs", "spades" };
            string[] hearts = { "a", "2", "3", "4", "5", "6", "7", "8", "9","10", "j", "q", "k" };
            string[] diamonds = { "a", "2", "3", "4", "5", "6", "7", "8", "9", "10", "j", "q", "k" };
            string[] clubs = { "a", "2", "3", "4", "5", "6", "7", "8", "9", "10", "j", "q", "k" };
            string[] spades = { "a", "2", "3", "4", "5", "6", "7", "8", "9","10", "j", "q", "k" };

            getCard(cardSuit, hearts, diamonds, clubs, spades);
            
            //getCard(cardSuit, hearts, diamonds, clubs, spades);

        }
        static void getCard(string[] cardSuit, string[] hearts, string[] diamonds, string[] clubs, string[] spades)
        {

            int suitArrayLength = cardSuit.Length;
            string cardVal ="";

            Random random = new Random();
            int cardPosition = random.Next(0, suitArrayLength - 1);
            string cardSuitSelected = cardSuit[cardPosition];;
            if (cardSuitSelected == "hearts")
            {
                int valueLength = hearts.Length;
                int valuePosition = random.Next(0, valueLength - 1);
                cardVal = hearts[valuePosition];
                string cardValNew = "";
                if (cardVal == "a")
                {
                    cardValNew = "Ace";
                }
                else if (cardVal == "2")
                {
                    cardValNew = "2";
                }
                else if (cardVal == "3")
                {
                    cardValNew = "3";
                }
                else if (cardVal == "4")
                {
                    cardValNew = "4";
                }
                else if (cardVal == "5")
                {
                    cardValNew = "5";
                }
                else if (cardVal == "6")
                {
                    cardValNew = "6";
                }
                else if (cardVal == "7")
                {
                    cardValNew = "7";
                }
                else if (cardVal == "8")
                {
                    cardValNew = "8";
                }
                else if (cardVal == "9")
                {
                    cardValNew = "9";
                }
                else if (cardVal == "10")
                {
                    cardValNew = "10";
                }
                else if (cardVal == "j")
                {
                    cardValNew = "Jack";
                }
                else if (cardVal == "q")
                {
                    cardValNew = "Queen";
                }
                else if (cardVal == "k")
                {
                    cardValNew = "King";
                }

                Console.WriteLine("Your card is the " + cardValNew + " of hearts");
                Console.ReadLine();

                string previousSuitVal = cardSuitSelected;
                string previousCardVal = cardVal;
                DeleteCardFromArray(cardSuit, hearts, diamonds, clubs, spades, cardSuitSelected, cardVal, previousSuitVal, previousCardVal);

            }
            else if (cardSuitSelected == "diamonds")
            {
                int valueLength = diamonds.Length;
                int valuePosition = random.Next(0, valueLength - 1);
                cardVal = diamonds[valuePosition];
                string cardValNew = "";
                if (cardVal == "a")
                {
                    cardValNew = "Ace";
                }
                else if (cardVal == "2")
                {
                    cardValNew = "2";
                }
                else if (cardVal == "3")
                {
                    cardValNew = "3";
                }
                else if (cardVal == "4")
                {
                    cardValNew = "4";
                }
                else if (cardVal == "5")
                {
                    cardValNew = "5";
                }
                else if (cardVal == "6")
                {
                    cardValNew = "6";
                }
                else if (cardVal == "7")
                {
                    cardValNew = "7";
                }
                else if (cardVal == "8")
                {
                    cardValNew = "8";
                }
                else if (cardVal == "9")
                {
                    cardValNew = "9";
                }
                else if (cardVal == "10")
                {
                    cardValNew = "10";
                }
                else if (cardVal == "j")
                {
                    cardValNew = "Jack";
                }
                else if (cardVal == "q")
                {
                    cardValNew = "Queen";
                }
                else if (cardVal == "k")
                {
                    cardValNew = "King";
                }

                Console.WriteLine("Your card is the " + cardValNew + " of diamonds");
                Console.ReadLine();

                string previousSuitVal = cardSuitSelected;
                string previousCardVal = cardVal;
                DeleteCardFromArray(cardSuit, hearts, diamonds, clubs, spades, cardSuitSelected, cardVal, previousSuitVal, previousCardVal);
            }
            else if (cardSuitSelected == "clubs")
            {
                int valueLength = clubs.Length;
                int valuePosition = random.Next(0, valueLength - 1);
                cardVal = clubs[valuePosition];
                string cardValNew = "";
                if (cardVal == "a")
                {
                    cardValNew = "Ace";
                }
                else if (cardVal == "2")
                {
                    cardValNew = "2";
                }
                else if (cardVal == "3")
                {
                    cardValNew = "3";
                }
                else if (cardVal == "4")
                {
                    cardValNew = "4";
                }
                else if (cardVal == "5")
                {
                    cardValNew = "5";
                }
                else if (cardVal == "6")
                {
                    cardValNew = "6";
                }
                else if (cardVal == "7")
                {
                    cardValNew = "7";
                }
                else if (cardVal == "8")
                {
                    cardValNew = "8";
                }
                else if (cardVal == "9")
                {
                    cardValNew = "9";
                }
                else if (cardVal == "10")
                {
                    cardValNew = "10";
                }
                else if (cardVal == "j")
                {
                    cardValNew = "Jack";
                }
                else if (cardVal == "q")
                {
                    cardValNew = "Queen";
                }
                else if (cardVal == "k")
                {
                    cardValNew = "King";
                }

                Console.WriteLine("Your card is the " + cardValNew + " of clubs");
                Console.ReadLine();

                string previousSuitVal = cardSuitSelected;
                string previousCardVal = cardVal;
                DeleteCardFromArray(cardSuit, hearts, diamonds, clubs, spades, cardSuitSelected, cardVal, previousSuitVal, previousCardVal);
            }
            else if (cardSuitSelected == "spades")
            {
                int valueLength = spades.Length;
                int valuePosition = random.Next(0, valueLength - 1);
                cardVal = spades[valuePosition];
                string cardValNew = "";
                if (cardVal == "a")
                {
                    cardValNew = "Ace";
                }
                else if (cardVal == "2")
                {
                    cardValNew = "2";
                }
                else if (cardVal == "3")
                {
                    cardValNew = "3";
                }
                else if (cardVal == "4")
                {
                    cardValNew = "4";
                }
                else if (cardVal == "5")
                {
                    cardValNew = "5";
                }
                else if (cardVal == "6")
                {
                    cardValNew = "6";
                }
                else if (cardVal == "7")
                {
                    cardValNew = "7";
                }
                else if (cardVal == "8")
                {
                    cardValNew = "8";
                }
                else if (cardVal == "9")
                {
                    cardValNew = "9";
                }
                else if (cardVal == "10")
                {
                    cardValNew = "10";
                }
                else if (cardVal == "j")
                {
                    cardValNew = "Jack";
                }
                else if (cardVal == "q")
                {
                    cardValNew = "Queen";
                }
                else if (cardVal == "k")
                {
                    cardValNew = "King";
                }
                Console.WriteLine("Your card is the " + cardValNew + " of spades");
                Console.ReadLine();

                string previousSuitVal = cardSuitSelected;
                string previousCardVal = cardVal;
                DeleteCardFromArray(cardSuit, hearts, diamonds, clubs, spades, cardSuitSelected, cardVal, previousSuitVal, previousCardVal);
            }
        }

        static int DeleteCardFromArray(string[] cardSuit, string[] hearts, string[] diamonds, string[] clubs, string[] spades, string cardSuitSelected, string cardVal,string previousSuitVal, string previousCardVal)
        {
            int positionDelete =0;
            if (cardSuitSelected == "hearts")
            {
                for (int i = 0; i < hearts.Length; i++)
                {
                    if (hearts[i] == cardVal)
                    {
                        positionDelete = i;
                    }
                }
                int loopFor = hearts.Length - positionDelete;
                for (int i = positionDelete; i <hearts.Length-1; i++)
                {
                    hearts[i] = hearts[i + 1];
                }
                hearts[hearts.Length-1] = "";
                /*Console.Write("The new array is : ");
                for (int i = 0; i <= hearts.Length-1; i++)
                {
                    Console.Write(hearts[i]);
                }
                Console.ReadLine();*/
                usersGuess(cardSuit, hearts, diamonds, clubs, spades, previousSuitVal, previousCardVal);
            }
            else if (cardSuitSelected == "diamonds")
            {
                for (int i = 0; i < diamonds.Length; i++)
                {
                    if (diamonds[i] == cardVal)
                    {
                        positionDelete = i;
                    }
                }
                for (int i = positionDelete ; i < diamonds.Length - 1; i++)
                {
                    diamonds[i] = diamonds[i + 1];
                }
                diamonds[diamonds.Length - 1] = "";
               /* Console.Write("The new array is : ");
                for (int i = 0; i < diamonds.Length-1; i++)
                {
                    Console.Write(diamonds[i]);
                }
                Console.ReadLine();*/
                usersGuess(cardSuit, hearts, diamonds, clubs, spades, previousSuitVal, previousCardVal);
            }
            else if (cardSuitSelected == "spades")
            {
                for (int i = 0; i < spades.Length; i++)
                {
                    if (spades[i] == cardVal)
                    {
                        positionDelete = i;
                    }
                }
                for (int i = positionDelete ; i < spades.Length-1; i++)
                {
                    spades[i] = spades[i + 1];
                }
                spades[spades.Length - 1]="";
                /*Console.Write("The new array is : ");
                for (int i = 0; i < spades.Length-1; i++)
                {
                    Console.Write(spades[i]);
                }
                Console.ReadLine();*/
                usersGuess(cardSuit, hearts, diamonds, clubs, spades, previousSuitVal, previousCardVal);
            }
            else if (cardSuitSelected == "clubs")
            {
                for (int i = 0; i < clubs.Length; i++)
                {
                    if (clubs[i] == cardVal)
                    {
                        positionDelete = i;
                    }
                }
                for (int i = positionDelete ; i < clubs.Length- 1; i++)
                {
                    clubs[i] = clubs[i + 1];
                }
                clubs[clubs.Length-1] = "";
                /*Console.Write("The new array is : ");
                for (int i = 0; i < clubs.Length-1; i++)
                {
                    Console.Write(clubs[i]);
                }
                Console.ReadLine();*/
                usersGuess(cardSuit, hearts, diamonds, clubs, spades, previousSuitVal, previousCardVal);
            }
            return positionDelete;
        }

        static string usersGuess(string[] cardSuit,string[] hearts, string[]diamonds,string[] clubs,string[] spades, string previousSuitVal,string previousCardVal)
        {
            string usersInput;
            Console.WriteLine("Do you think the next card will be higher(h) or lower(l) than this card?");
            usersInput = Console.ReadLine();

            if (usersInput.Length == 1)
            {
                if (usersInput == "h")
                {
                    Console.WriteLine("You have choosen higher");
                    Console.ReadLine();
                    getNewCard(cardSuit, hearts, diamonds, clubs, spades, previousSuitVal, previousCardVal, usersInput);
                }
                else if (usersInput == "l")
                {
                    Console.WriteLine("You have choosen lower");
                    Console.ReadLine();
                    getNewCard(cardSuit, hearts, diamonds, clubs, spades, previousSuitVal, previousCardVal, usersInput);
                }
                else
                {
                    Console.WriteLine("Incorrect input...Closing app...");
                    Console.ReadLine();
                    closeApp();
                }
            }
            else
            {
                Console.WriteLine("Incorrect input ...Closing app..");
                Console.ReadLine();
                closeApp();
            }
            return usersInput;
        }

        static void getNewCard(string[] cardSuit, string[] hearts, string[] diamonds, string[] clubs, string[] spades,string previousSuitVal,string previousCardVal, string usersInput)
        {
            int suitArrayLength = cardSuit.Length;
            string cardVal = "";

            Random random = new Random();
            int cardPosition = random.Next(0, suitArrayLength - 1);
            string cardSuitSelected = cardSuit[cardPosition];
            if (cardSuitSelected == "hearts")
            {
                int valueLength = hearts.Length;
                int valuePosition = random.Next(0, valueLength - 1);
                cardVal = hearts[valuePosition];
                string cardValNew = "";
                if (cardVal == "a")
                {
                    cardValNew = "Ace";
                }
                else if (cardVal == "2")
                {
                    cardValNew = "2";
                }
                else if (cardVal == "3")
                {
                    cardValNew = "3";
                }
                else if (cardVal == "4")
                {
                    cardValNew = "4";
                }
                else if (cardVal == "5")
                {
                    cardValNew = "5";
                }
                else if (cardVal == "6")
                {
                    cardValNew = "6";
                }
                else if (cardVal == "7")
                {
                    cardValNew = "7";
                }
                else if (cardVal == "8")
                {
                    cardValNew = "8";
                }
                else if (cardVal == "9")
                {
                    cardValNew = "9";
                }
                else if (cardVal == "10")
                {
                    cardValNew = "10";
                }
                else if (cardVal == "j")
                {
                    cardValNew = "Jack";
                }
                else if (cardVal == "q")
                {
                    cardValNew = "Queen";
                }
                else if (cardVal == "k")
                {
                    cardValNew = "King";
                }

                Console.WriteLine("Your card is the " + cardValNew + " of hearts");
                Console.ReadLine();

                string currentSuitVal = cardSuitSelected;
                string currentCardVal = cardVal;
                DeletNewCardFromArray(cardSuit, hearts, diamonds, clubs, spades, currentSuitVal, currentCardVal, previousSuitVal, previousCardVal, usersInput);
            }
            else if (cardSuitSelected == "diamonds")
            {
                int valueLength = diamonds.Length;
                int valuePosition = random.Next(0, valueLength - 1);
                cardVal = diamonds[valuePosition];
                string cardValNew = "";
                if (cardVal == "a")
                {
                    cardValNew = "Ace";
                }
                else if (cardVal == "2")
                {
                    cardValNew = "2";
                }
                else if (cardVal == "3")
                {
                    cardValNew = "3";
                }
                else if (cardVal == "4")
                {
                    cardValNew = "4";
                }
                else if (cardVal == "5")
                {
                    cardValNew = "5";
                }
                else if (cardVal == "6")
                {
                    cardValNew = "6";
                }
                else if (cardVal == "7")
                {
                    cardValNew = "7";
                }
                else if (cardVal == "8")
                {
                    cardValNew = "8";
                }
                else if (cardVal == "9")
                {
                    cardValNew = "9";
                }
                else if (cardVal == "10")
                {
                    cardValNew = "10";
                }
                else if (cardVal == "j")
                {
                    cardValNew = "Jack";
                }
                else if (cardVal == "q")
                {
                    cardValNew = "Queen";
                }
                else if (cardVal == "k")
                {
                    cardValNew = "King";
                }

                Console.WriteLine("Your card is the " + cardValNew + " of diamonds");
                Console.ReadLine();

                string currentSuitVal = cardSuitSelected;
                string currentCardVal = cardVal;
                DeletNewCardFromArray(cardSuit, hearts, diamonds, clubs, spades, currentSuitVal, currentCardVal, previousSuitVal, previousCardVal, usersInput);
            }
            else if (cardSuitSelected == "clubs")
            {
                int valueLength = clubs.Length;
                int valuePosition = random.Next(0, valueLength - 1);
                cardVal = clubs[valuePosition];
                string cardValNew = "";
                if (cardVal == "a")
                {
                    cardValNew = "Ace";
                }           // could do this as a method
                else if (cardVal == "2")
                {
                    cardValNew = "2";
                }
                else if (cardVal == "3")
                {
                    cardValNew = "3";
                }
                else if (cardVal == "4")
                {
                    cardValNew = "4";
                }
                else if (cardVal == "5")
                {
                    cardValNew = "5";
                }
                else if (cardVal == "6")
                {
                    cardValNew = "6";
                }
                else if (cardVal == "7")
                {
                    cardValNew = "7";
                }
                else if (cardVal == "8")
                {
                    cardValNew = "8";
                }
                else if (cardVal == "9")
                {
                    cardValNew = "9";
                }
                else if (cardVal == "10")
                {
                    cardValNew = "10";
                }
                else if (cardVal == "j")
                {
                    cardValNew = "Jack";
                }
                else if (cardVal == "q")
                {
                    cardValNew = "Queen";
                }
                else if (cardVal == "k")
                {
                    cardValNew = "King";
                }
                Console.WriteLine("Your card is the " + cardValNew + " of clubs");
                Console.ReadLine();

                string currentSuitVal = cardSuitSelected;
                string currentCardVal = cardVal;
                DeletNewCardFromArray(cardSuit, hearts, diamonds, clubs, spades, currentSuitVal, currentCardVal, previousSuitVal, previousCardVal, usersInput);
            }
            else if (cardSuitSelected == "spades")
            {
                int valueLength = spades.Length;
                int valuePosition = random.Next(0, valueLength - 1);
                cardVal = spades[valuePosition];
                string cardValNew = "";
                if (cardVal == "a")
                {
                    cardValNew = "Ace";
                }
                else if (cardVal == "2")
                {
                    cardValNew = "2";
                }
                else if (cardVal == "3")
                {
                    cardValNew = "3";
                }
                else if (cardVal == "4")
                {
                    cardValNew = "4";
                }
                else if (cardVal == "5")
                {
                    cardValNew = "5";
                }
                else if (cardVal == "6")
                {
                    cardValNew = "6";
                }
                else if (cardVal == "7")
                {
                    cardValNew = "7";
                }
                else if (cardVal == "8")
                {
                    cardValNew = "8";
                }
                else if (cardVal == "9")
                {
                    cardValNew = "9";
                }
                else if (cardVal == "10")
                {
                    cardValNew = "10";
                }
                else if (cardVal == "j")
                {
                    cardValNew = "Jack";
                }
                else if (cardVal == "q")
                {
                    cardValNew = "Queen";
                }
                else if (cardVal == "k")
                {
                    cardValNew = "King";
                }
                Console.WriteLine("Your card is the " + cardValNew + " of spades");
                Console.ReadLine();

                string currentSuitVal = cardSuitSelected;
                string currentCardVal = cardVal;
                DeletNewCardFromArray(cardSuit, hearts, diamonds, clubs, spades, currentSuitVal, currentCardVal, previousSuitVal, previousCardVal, usersInput);
            }
        }

        static void DeletNewCardFromArray(string[] cardSuit, string[] hearts, string[] diamonds, string[] clubs, string[] spades, string currentSuitVal, string currentCardVal,string previousSuitVal, string previousCardVal,string usersInput)
        {
            string prevNumTest = previousCardVal;
            string prevCardName = previousSuitVal;
            int positionDelete = 0;

            if (currentSuitVal == "hearts")
            {
                for (int i = 0; i < hearts.Length; i++)
                {
                    if (hearts[i] == currentCardVal)
                    {
                        positionDelete = i;
                    }
                }
                //Console.WriteLine("position delete : " + positionDelete);
                int loopFor = hearts.Length - positionDelete;
                for (int i = positionDelete; i < hearts.Length - 1; i++)
                {
                    hearts[i] = hearts[i + 1];
                }
                hearts[hearts.Length - 1] = "";

                /* Console.Write("The new array is : ");
                 for (int i = 0; i <= hearts.Length - 1; i++)
                 {
                     Console.Write(hearts[i]);
                 }
                 Console.ReadLine();*/
                checkingUserGuess(cardSuit, hearts, diamonds, clubs, spades, currentCardVal, currentSuitVal, previousSuitVal, previousCardVal, usersInput, prevNumTest, prevCardName);
            }

            else if (currentSuitVal == "diamonds")
            {
                for (int i = 0; i < diamonds.Length; i++)
                {
                    if (diamonds[i] == currentCardVal)
                    {
                        positionDelete = i;
                    }
                }
               // Console.WriteLine("position delete : " + positionDelete);
                for (int i = positionDelete; i < diamonds.Length - 1; i++)
                {
                    diamonds[i] = diamonds[i + 1];
                }
                diamonds[diamonds.Length - 1] = "";
                /*Console.Write("The new array is : ");
                for (int i = 0; i < diamonds.Length - 1; i++)
                {
                    Console.Write(diamonds[i]);
                }
                Console.ReadLine();*/
                checkingUserGuess(cardSuit, hearts, diamonds, clubs, spades, currentCardVal, currentSuitVal, previousSuitVal, previousCardVal, usersInput, prevNumTest, prevCardName);
            }

            else if (currentSuitVal == "spades")
            {
                for (int i = 0; i < spades.Length; i++)
                {
                    if (spades[i] == currentCardVal)
                    {
                        positionDelete = i;
                    }
                }
                //Console.WriteLine("position delete : " + positionDelete);
                for (int i = positionDelete; i < spades.Length - 1; i++)
                {
                    spades[i] = spades[i + 1];
                }
                spades[spades.Length - 1] = "";
                /*Console.Write("The new array is : ");
                for (int i = 0; i < spades.Length - 1; i++)
                {
                    Console.Write(spades[i]);
                }
                Console.ReadLine();*/
                checkingUserGuess(cardSuit, hearts, diamonds, clubs, spades, currentCardVal, currentSuitVal, previousSuitVal, previousCardVal, usersInput, prevNumTest, prevCardName);
            }

            else if (currentSuitVal == "clubs")
            {
                for (int i = 0; i < clubs.Length; i++)
                {
                    if (clubs[i] == currentCardVal)
                    {
                        positionDelete = i;
                    }
                }
                //Console.WriteLine("position delete : " + positionDelete);
                for (int i = positionDelete; i < clubs.Length - 1; i++)
                {
                    clubs[i] = clubs[i + 1];
                }
                clubs[clubs.Length-1] = "";
                /*Console.Write("The new array is : ");
                for (int i = 0; i < clubs.Length - 1; i++)
                {
                    Console.Write(clubs[i]);
                }
                Console.ReadLine();*/
                checkingUserGuess(cardSuit,hearts,diamonds,clubs,spades, currentCardVal, currentSuitVal,previousSuitVal, previousCardVal,  usersInput, prevNumTest, prevCardName);
            }
            //return positionDelete;
        }
        static void checkingUserGuess(string[] cardSuit, string[] hearts, string[] diamonds, string[] clubs, string[] spades, string currentCardVal,string currentSuitVal,string previousSuitVal,string previousCardVal,   string usersInput, string prevNumTest, string prevCardName)
        {
           
            bool higher;
            int current = 0;
            int previous=0;

            if (prevNumTest == "a")
            {
                previousCardVal = "Ace";
                previous = 1;
            }
            else if (prevNumTest == "2")
            {
                previous = 2;

            }
            else if (prevNumTest == "3")
            {
                previous = 3;
            }
            else if (prevNumTest == "4")
            {
                previous=4;
            }
            else if (prevNumTest == "5")
            {
                previous=5;
            }
            else if (prevNumTest == "6")
            {
                previous=6;
            }
            else if (prevNumTest == "7")
            {
                previous =7;
            }
            else if (prevNumTest == "8")
            {
                previous=8;

            }
            else if (prevNumTest == "9")
            {
                previous=9;
            }
            else if (prevNumTest == "10")
            {
                previous = 10;
            }
            else if (prevNumTest == "j")
            {
                previousCardVal = "Jack";
                previous = 11;
            }
            else if (prevNumTest == "q")
            {
                previousCardVal = "Queen";
                previous = 12;
            }
            else if (prevNumTest == "k")
            {
                previousCardVal = "King";
                previous = 13;
            }

            if (currentCardVal == "a")
            {
                currentCardVal = "Ace";
                current = 1;
            }
            else if (currentCardVal == "2")
            {
                current = 2;
            }
            else if (currentCardVal == "3")
            {
                current = 3;
            }
            else if (currentCardVal == "4")
            {
                current = 4;
            }
            else if (currentCardVal == "5")
            {
                current = 5;
            }
            else if (currentCardVal == "6")
            {
                current = 6;
            }
            else if (currentCardVal == "7")
            {
                current = 7;
            }
            else if (currentCardVal == "8")
            {
                current = 8;
            }
            else if (currentCardVal == "9")
            {
                current = 9;
            }
            else if (currentCardVal == "10")
            {
                current = 10;
            }
            else if (currentCardVal == "j")
            {
                currentCardVal = "Jack";
                current = 11;
            }
            else if (currentCardVal == "q")
            {
                currentCardVal = "Queen";
                current = 12;
            }
            else if (currentCardVal == "k")
            {
                currentCardVal = "King";
                current = 13;
            }

             if (current>previous)
            {
                if (usersInput == "h")
                {
                    Console.WriteLine("The current card is the " + currentCardVal + " of " + prevCardName);
                    Console.WriteLine(" Congrats!! You guessed corrrectly!! ");
                    Console.ReadLine();
                    previousSuitVal = currentSuitVal;
                    previousCardVal = currentCardVal;
                   // Console.WriteLine("swithcing card \ncard val : " + previousCardVal + "\ncard suit : " + previousSuitVal);
                    // getNewCard();
                    usersGuess(cardSuit, hearts, diamonds, clubs, spades, previousSuitVal, previousCardVal);
                }
                else
                {
                    Console.WriteLine("The current card is the " + currentCardVal + " of " + prevCardName);
                    Console.WriteLine("Unlucky!  The current card was higher then the previous. You loose... \n Closing app..." );
                    Console.ReadLine();
                    closeApp();
                }
            }
            else if (previous>current)
            {
                if (usersInput == "l")
                {
                    Console.WriteLine("The current card is the " + currentCardVal + " of " + prevCardName);
                    Console.WriteLine("Congrats!! You guessed correctly!!");
                    Console.ReadLine();

                    previousSuitVal = currentSuitVal;
                    previousCardVal = currentCardVal;               //THIS IS CORRECT!!!!
                   // Console.WriteLine("swithcing card \ncard val : " + previousCardVal + "\ncard suit : " + previousSuitVal);
                    // getNewCard();
                    usersGuess(cardSuit, hearts, diamonds, clubs, spades, previousSuitVal, previousCardVal);
                }
                else
                {
                    Console.WriteLine("The current card is the " + currentCardVal + " of " + prevCardName);
                    Console.WriteLine("Unlucky!  The current card was lower then the previous. You loose... \n Closing app...");
                    Console.ReadLine();
                    closeApp();
                }
            }
             else if(previous == current)
            {
                Console.WriteLine("The current card is the " + currentCardVal + " of " + prevCardName);
                Console.WriteLine("The previous card and current card are equal. You loose... \n Closing app...");
                Console.ReadLine();
                closeApp();
            }
        }

        static void closeApp()
        {

        }
    }
}
