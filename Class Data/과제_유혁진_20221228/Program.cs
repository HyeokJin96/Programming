namespace 과제_유혁진_20221228
{
    internal class TrumpCard
    {
        static void Main(string[] args)
        {
            //  LAB
            /**
             * 카드 뽑기
             * 컴퓨터가 2장을 뽑아서 보여줌
             * 플레이어가 배팅을 함(패스 가능, 10,000 포인트 소지)
             * 플레이어가 뽑은 카드가 컴퓨터가 뽑은 2장의 카드 사이에 있는 카드라면 플레이어가 배팅 포인트의 2배를 얻음
             * 플레이어가 뽑은 카드가 컴퓨터가 뽑은 2장의 카드 사이에 없는 카드라면 플레이어가 배팅한 포인트를 잃음
             * 카드의 대,소 비교는 숫자로만
             * 100,000 포인트를 벌거나 모두 잃었을 경우 게임 종료
             */
            TrumpCard trumpCard = new TrumpCard();
            trumpCard.Dealer();
        }

        public int[] firstTrumpCardSet;
        public string[] firsttrumCardMark;
        public int[] secondTrumpCardSet;
        public string[] secondtrumCardMark;
        bool isTrue = false;

        public void SetupTrumpCards()       //  트럼프카드 셋업
        {
                firstTrumpCardSet = new int[52];

                for (int i = 0; i < firstTrumpCardSet.Length; i++)
                {
                    firstTrumpCardSet[i] = i + 1;
                }

                firsttrumCardMark = new string[4] { "♥", "♠", "◆", "♣" };

                secondTrumpCardSet = new int[52];

                for (int y = 0; y < secondTrumpCardSet.Length; y++)
                {
                    secondTrumpCardSet[y] = y + 1;
                }

                secondtrumCardMark = new string[4] { "♥", "♠", "◆", "♣" };

        }

        public int[] firstShuffle(int[] intfirstArray)
        {
            Random random = new Random();
            int firstCard = random.Next(0, intfirstArray.Length);
            int secondCard = random.Next(0, intfirstArray.Length);

            int tempCard = intfirstArray[firstCard];

            intfirstArray[firstCard] = intfirstArray[secondCard];
            intfirstArray[secondCard] = tempCard;

            return intfirstArray;
        }

        public int[] secondShuffle(int[] intsecondArray)
        {
            Random random = new Random();
            int thirdCard = random.Next(0, intsecondArray.Length);
            int fourthdCard = random.Next(0, intsecondArray.Length);

            int tempCard = intsecondArray[thirdCard];

            intsecondArray[thirdCard] = intsecondArray[fourthdCard];
            intsecondArray[fourthdCard] = tempCard;

            return intsecondArray;
        }

        public void shuffleCards(int loopNumber)
        {
            bool gameStart = false;
            while (gameStart == false)
            {
                switch ()
                {
                    default:
                        break;
                }
            }
            for (int i = 0; i < loopNumber; i++)
            {
                firstTrumpCardSet = firstShuffle(firstTrumpCardSet);
            }
            for (int y = 0; y < loopNumber; y++)
            {
                secondTrumpCardSet = secondShuffle(secondTrumpCardSet);
            }
        }

        public void shuffleCards()
        {
            shuffleCards(100);
        }

        public void Rollcard()
        {
                int firstCard = firstTrumpCardSet[0];
                string firstCardmark = firsttrumCardMark[(firstCard - 1 / 13) / 13];
                string firstCardnumber = Math.Ceiling(firstCard % 13.1).ToString();

                int secondCard = secondTrumpCardSet[0];
                string secondCardmark = firsttrumCardMark[(secondCard - 1 / 13) / 13];
                string secondCardnumber = Math.Ceiling(secondCard % 13.1).ToString();


                switch (firstCardnumber)
                {
                    case "11":
                        firstCardnumber = "J";
                        break;
                    case "12":
                        firstCardnumber = "Q";
                        break;
                    case "13":
                        firstCardnumber = "K";
                        break;
                    default:
                        /* Do nothing */
                        break;
                }

                switch (secondCardnumber)
                {
                    case "11":
                        secondCardnumber = "J";
                        break;
                    case "12":
                        secondCardnumber = "Q";
                        break;
                    case "13":
                        secondCardnumber = "K";
                        break;
                    default:
                        /* Do nothing */
                        break;
                }
                Console.WriteLine("딜러가 뽑은 카드는 {0}{1}과 {2}{3} 입니다.", firstCardmark, firstCardnumber, secondCardmark, secondCardnumber);
                Console.WriteLine("┌-------┐  ┌-------┐");
                Console.WriteLine("│ {0}  {1} │  │ {2}  {3} │", firstCardmark, firstCardnumber, secondCardmark, secondCardnumber);
                Console.WriteLine("│       │  │       │");
                Console.WriteLine("│       │  │       │");
                Console.WriteLine("│       │  │       │");
                Console.WriteLine("│ {0}  {1} │  │ {2}  {3} │", firstCardmark, firstCardnumber, secondCardmark, secondCardnumber);
                Console.WriteLine("└-------┘  └-------┘");
            }
            
        public void Dealer()
        {
            SetupTrumpCards();
            shuffleCards();
            Rollcard();
        }
    }
}