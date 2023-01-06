using System;

namespace Project._Slay_the_Spire
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.SetWindowSize(150, 35);     //  콘솔 화면 크기 지정하기

            Program program = new Program();
            Screen screen = new Screen();
            Character character = new Character();

            screen.MainMenu();

            /*
             * 메인메뉴에서 방향키 조작으로 옵션을 선택 -> 게임 정보 선택 시 게임 정보 화면으로 전환 -> 이후 메인메뉴로 돌아오기
             * 게임시작 선택시 게임을 시작한다. -> 캐릭터 선택
             * 캐릭터 선택시 캐릭터명 그리고 간단한 정보들을 포함해서 보여줌
             * 캐릭터는 플레이어가 선택할 수 있어야 함
             * 선택 후 맵 화면을 출력함
             * 맵에 플레이어의 현재 위치를 알 수 있는 표시가 있어야 함
             * 맵을보고 플레이어가 루트를 선택하여 진행 -> 조작은 동일하게 방향키로
             * 맵은 약 30스테이지로 마지막 스테이지는 보스 전투
             * 일반 몬스터 스테이지(10), 엘리트 몬스터 스테이지(5), 상점(3), 휴식처(3), 랜덤(8), 보스(1)
             * 스테이지 이동 시 이벤트 발생 -> 이벤트는 일반 몬스터, 엘리트 몬스터, 상점, 휴식처 등으로 구성
             * 몬스터와의 전투 이벤트 발생 시 화면에 위쪽에는 몬스터의 이미지와 정보를 출력함 -> 몬스터의 정보는 체력, 공격력, 방어력 등
             * 아래쪽에는 플레이어의 카드들을 출력함 -> 왼쪽에는 카드 덱 / 중앙에는 뽑은 카드들 / 오른쪽에는 버려지 카드 더미를 구현한다.
             * 그럼 플레이어의 정보창이나 아이템 등의 화면은 어디에? -> 최상단(몬스터 위)에 출력하는 것이 좋을듯함
             * 전투가 끝나면 보상화면을 출력함
             * 보상은 플레이어가 선택하여 획득할 수 있어야 함
             * 선택 후 다시 맵 화면을 출력함 -> 반복 -> 엔딩
             */



        }   //  Main ()


    }   //  class Program

    class Screen
    {
        //  메인 화면
        public void MainMenu()
        {

            Console.WriteLine("\n\n");
            Console.WriteLine("\t      ::::::::       :::            :::     :::   :::    :::::::::::       :::    :::       ::::::::::");
            Console.WriteLine("\t    :+:    :+:      :+:          :+: :+:   :+:   :+:        :+:           :+:    :+:       :+:");
            Console.WriteLine("\t   +:+             +:+         +:+   +:+   +:+ +:+         +:+           +:+    +:+       +:+ ");
            Console.WriteLine("\t  +#++:++#++      +#+        +#++:++#++:   +#++:          +#+           +#++:++#++       +#++:++#");
            Console.WriteLine("\t        +#+      +#+        +#+     +#+    +#+           +#+           +#+    +#+       +#+");
            Console.WriteLine("\t#+#    #+#      #+#        #+#     #+#    #+#           #+#           #+#    #+#       #+#");
            Console.WriteLine("\t########       ########## ###     ###    ###           ###           ###    ###       ##########");
            Console.WriteLine("");
            Console.WriteLine("\t                                                            ::::::::       :::::::::       :::::::::::       :::::::::       ::::::::::");
            Console.WriteLine("\t                                                          :+:    :+:      :+:    :+:          :+:           :+:    :+:      :+:");
            Console.WriteLine("\t                                                         +:+             +:+    +:+          +:+           +:+    +:+      +:+");
            Console.WriteLine("\t                                                        +#++:++#++      +#++:++#+           +#+           +#++:++#:       +#++:++#");
            Console.WriteLine("\t                                                              +#+      +#+                 +#+           +#+    +#+      +#+");
            Console.WriteLine("\t                                                      #+#    #+#      #+#                 #+#           #+#    #+#      #+#");
            Console.WriteLine("\t                                                      ########       ###             ###########       ###    ###      ##########");
            Console.WriteLine("\n\n\n\n\n\n");
            Console.WriteLine("\t\t\t\t\t\t\t\t >  게 임 시 작\n");
            Console.WriteLine("\t\t\t\t\t\t\t\t    게 임 정 보\n");
            Console.WriteLine("\t\t\t\t\t\t\t\t      종  료\n");


        }   //  MainMenu

        //  게임정보
        public void Information()
        {
        }   //  Information

        //  메인메뉴 선택옵션
        public void MainMenuSelection()
        {
            string[,] selection = new string[2, 0];
            selection[0, 0] = "> 게임시작";
            selection[1, 0] = "게임정보";
            selection[2, 0] = "종료";

        }   //  MainMenuSelection


        public void Control()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "w":
                    break;
                case "s":
                    break;
                case "a":
                    break;
                case "d":
                    break;
                default:
                    break;
            }
        }

    }   //  class Screen


    public class Character
    {
        public string name;    //  클래스 이름
        int HP;         //  Health Point, 체력
        int STR;        //  Strangth, 힘
        int Dex;        //  Dexterity, 민첩
        int Wis;        //  Wisdom, 지혜  
        int LUCK;       //  행운
        int gold;       //  골드

        //  모험가 클래스 정보
        public void Adventurer()
        {
            name = "모험가";
            HP = 80;
            STR = 3;
            Dex = 3;
            Wis = 3;
            LUCK = 3;
            gold = 100;
        }   //  Adventurer

        //  기사 클래스 정보
        public void Knight()
        {
            name = "기사";
            HP = 100;
            STR = 5;
            Dex = 5;
            Wis = 1;
            LUCK = 1;
            gold = 100;
        }   //  Knight

        //  마법사 클래스 정보
        public void Wizard()
        {
            name = "마법사";
            HP = 60;
            STR = 10;
            Dex = 1;
            Wis = 5;
            LUCK = 2;
            gold = 100;
        }   //  Wizard

        //  도적 클래스 정보
        public void Thief()
        {
            name = "도적";
            HP = 50;
            STR = 2;
            Dex = 2;
            Wis = 5;
            LUCK = 3;
            gold = 100;
        }   //  Thief

        //  도박 중독자 클래스 정보
        public void GamblingAddict()
        {
            name = "도박 중독자";
            HP = 50;
            STR = 1;
            Dex = 1;
            Wis = 1;
            LUCK = 10;
            gold = 100;
        }   //  Gambler


    }   //  class Character

    public class Monster
    {
        //  가시 슬라임 정보
        public void SpikeSlime()
        {
            
        }

        //  산성 슬라임 정보
        public void AcidSlime()
        {

        }

        //  도적 정보
        public void Looter()
        {

        }

        //  노예 상인 정보
        public void Slaver()
        {

        }

        //  
    }   //  class Monster

    public class Card
    {

    }   //  class Card

    public class Item
    {

    }   //  class Item

    public class Relics
    {

    }   //  class Relics

    public class Event
    {

    }   //  class Event
}