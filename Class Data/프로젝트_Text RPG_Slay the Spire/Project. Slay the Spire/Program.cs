using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Linq;
using System.Xml.Linq;
using System.Drawing;

namespace Project._Slay_the_Spire
{
    public class Program
    {
        string playerNAME;  //  플레이어 캐릭터 클래스(직업) 이름
        int playerHP;       //  Heath Point, 츨레이어 현재 체력
        int playerMAXHP;    //  Max Health Point, 플레이어 최대체력
        int playerSTR;      //  
        int playerDEX;
        int playerINT;
        int playerWIS;
        int playerLUCK;
        int playerGOLD;
        int playerATK;      //  Attack Power, 플레이어의 공격력
        int playerDEF;      //  Deffence Power, 플레이어의 방어력

        string monsterNAME;     //  몬스터 이름
        int monsterHP;          //  몬스터 체력
        int monsterMAXHP;       //  몬스터 최대 체력
        int monsterSTR;         //  몬스터 힘 스탯
        int monsterDEX;         //  몬스터 민첩 스탯
        int monsterINT;         //  몬스터 지능 스탯
        int monsterWIS;
        int monsterLUCK;
        int monsterATK;
        int monsterDEF;

        int basicATK = 5;       //  기본 공격력
        int basicDEF = 5;       //  기본 방어력

        int number1 = 1;
        int number2 = 2;
        int number3 = 3;

        int Floor = 1;

        int userInput;
        bool isGameOver = false;

        public static Program Game = new Program();
        public static Character playerCharacter = new Character();

        List<int> list = new List<int>();

        Random random = new Random();


        static void Main(string[] args)
        {
            Console.SetWindowSize(200, 50);     //  콘솔 화면 크기 지정

            Game.MainMenu();








            /*
             * UI수정 -> 정보(이름, 스탯 등), 인벤토리, 행동 선택 등
             * 
             * 행동 선택
             * 다음 층으로 진행 -> 이벤트 발생 (노말 몬스터 70% 엘리트 몬스터 30%) -> 층++
             * 수상한 방에 들어간다 -> 랜덤 이벤트 발생(체력회복, 수수께끼 상인, 보물, 강화 등) 다만 30% 확률로 몬스터가 출현함(이때는 보상을 조금만 얻음 or 얻지 못함) -> 이후 다음 층으로 진행 층++
             * 휴식한다 -> 체력을 10만큼 얻음 / 20% 확률로 체력을 10만큼 잃음 -> 이후 다음층으로 진행 층++
             * 
             * 이벤트 조건 설정 (이벤트; 노말 몬스터, 엘리트 몬스터, 상점 등)
             * 
             * 전투 설정
             * 전투 입장 시 몬스터의 체력, 공격력, 방어력 등을 표현 + 추가로 몬스터의 행동(다음 턴)
             * 입력을 받아 행동을 선택
             * 
             * 공격하기 -> 몬스터를 공격하면 몬스터의 체력이 바뀌어야함 -> 몬스터 턴
             * 방어하기 -> 몬스터의 턴으로 넘어감 이후 내 방어력만큼 몬스터의 공격을 막음
             * 도망치기 -> 도망을 선택할 경우 보상을 얻지 못함, 체력을 10만큼 잃음 / 또한 내 체력이 50% 이하일 경우에는 도망을 치지 못하며 25%확률로 체력만 잃고 도망치지 못함
             * 
             * 전투는 어떤식으로 구현하는가?
             * Console.ReadLine으로 입력을 받아서 행동을 선택
             * 선택한 행동을 실행 -> 변경사항을 출력함 -> 몬스터의 행동 실행
             * 반복 -> 내 체력이 0이 되거나 몬스터의 체력이 0이 될 때까지
             * + 보상
             * 
             * 층은 총 20층으로 마지막 20층은 보스몬스터가 출현함 -> 도망치기 x -> 이후 게임OVER
             */













        }   //  Main ()

        public void MainMenu()  //   메인화면
        {
            Console.Clear();

            Console.WriteLine("\n\n\n\n\n");
            Console.WriteLine("\t\t\t\t      ::::::::       :::            :::     :::   :::    :::::::::::       :::    :::       ::::::::::");
            Console.WriteLine("\t\t\t\t    :+:    :+:      :+:          :+: :+:   :+:   :+:        :+:           :+:    :+:       :+:");
            Console.WriteLine("\t\t\t\t   +:+             +:+         +:+   +:+   +:+ +:+         +:+           +:+    +:+       +:+ ");
            Console.WriteLine("\t\t\t\t  +#++:++#++      +#+        +#++:++#++:   +#++:          +#+           +#++:++#++       +#++:++#");
            Console.WriteLine("\t\t\t\t        +#+      +#+        +#+     +#+    +#+           +#+           +#+    +#+       +#+");
            Console.WriteLine("\t\t\t\t#+#    #+#      #+#        #+#     #+#    #+#           #+#           #+#    #+#       #+#");
            Console.WriteLine("\t\t\t\t########       ########## ###     ###    ###           ###           ###    ###       ##########");
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\t                                                            ::::::::       :::::::::       :::::::::::       :::::::::       ::::::::::");
            Console.WriteLine("\t\t\t\t                                                          :+:    :+:      :+:    :+:          :+:           :+:    :+:      :+:");
            Console.WriteLine("\t\t\t\t                                                         +:+             +:+    +:+          +:+           +:+    +:+      +:+");
            Console.WriteLine("\t\t\t\t                                                        +#++:++#++      +#++:++#+           +#+           +#++:++#:       +#++:++#");
            Console.WriteLine("\t\t\t\t                                                              +#+      +#+                 +#+           +#+    +#+      +#+");
            Console.WriteLine("\t\t\t\t                                                      #+#    #+#      #+#                 #+#           #+#    #+#      #+#");
            Console.WriteLine("\t\t\t\t                                                      ########       ###             ###########       ###    ###      ##########");
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t{1}   게 임 시 작\n");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t{2}   게 임 정 보\n");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t{3}     종   료");
            Console.Write("\n\n\n\t\t\t\t\t\t\t\t\t\t    {번호를 입력해서 진행} : ");

            while (isGameOver == false)
            {
                int.TryParse(Console.ReadLine(), out userInput);

                switch (userInput)
                {
                    case 1:
                        CharacterSelection();   //  1번 입력 : 캐릭터 선택 화면으로 넘어간다.
                        break;
                    case 2:
                        GameInformation();      //  2번 입력 : 게임정보 화면으로 넘어간다.
                        break;
                    case 3:
                        GameOver();             //  3번 입력 : 게임을 종료한다.
                        isGameOver = true;
                        break;
                    default:
                        ErrorMessage();         //  [ERROR]
                        MainMenu();
                        break;
                }
            }
        }   //  MainMenu

        public void GameInformation() //  게임정보
        {
            Console.Clear();

            Console.WriteLine("\n\n\n");
            Console.WriteLine("\t\t\t\t\t\t   #####   ##  ##   ######    ####    #####    ##  ##   ######   ######    #####    ####    ##  ##");
            Console.WriteLine("\t\t\t\t\t\t    ##     ### ##  ###  ##   ##  ##   ##  ##   ######  ###  ##     ##       ##     ##  ##   ### ##");
            Console.WriteLine("\t\t\t\t\t\t    ##    ######   ##       ##   ##  ##  ###  #######  ##  ##     ##        ##    ##   ##  ######");
            Console.WriteLine("\t\t\t\t\t\t   ##     ## ###  ######   ##   ##   ######   ##  ##  #######     ##       ##    ##   ##   ## ###");
            Console.WriteLine("\t\t\t\t\t\t   ##    ##  ##   ##       ##  ##   ##  ##   ##  ##   ##  ##     ##        ##    ##  ##   ##  ##");
            Console.WriteLine("\t\t\t\t\t\t #####   ##  ##   ##        ####    ##   ### ##  ##   ##  ##     ##      #####    ####    ##  ##");
            Console.WriteLine("\n\n\n\n");

            Console.WriteLine("메인메뉴로 나가려면 [Enter]를 누르세요.");

            while (isGameOver == false)
            {
                int.TryParse(Console.ReadLine(), out userInput);

                switch (userInput)
                {
                    case 0:
                        MainMenu();         //  0번 입력 : 메인메뉴로 복귀
                        isGameOver = true;
                        break;
                    default:
                        ErrorMessage();     //  [ERROR]
                        GameInformation();
                        break;
                }
            }
        }   //  GameInformation

        public void ErrorMessage()  //  잘못된 입력을 받을 경우 출력
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("\t\t\t\t\t\tEEEEEEEEEEEEEEEEEEEEEERRRRRRRRRRRRRRRRR   RRRRRRRRRRRRRRRRR        OOOOOOOOO     RRRRRRRRRRRRRRRRR   ");
            Console.WriteLine("\t\t\t\t\t\tE::::::::::::::::::::ER::::::::::::::::R  R::::::::::::::::R     OO:::::::::OO   R::::::::::::::::R  ");
            Console.WriteLine("\t\t\t\t\t\tE::::::::::::::::::::ER::::::RRRRRR:::::R R::::::RRRRRR:::::R  OO:::::::::::::OO R::::::RRRRRR:::::R ");
            Console.WriteLine("\t\t\t\t\t\tEE::::::EEEEEEEEE::::ERR:::::R     R:::::RRR:::::R     R:::::RO:::::::OOO:::::::ORR:::::R     R:::::R");
            Console.WriteLine("\t\t\t\t\t\t  E:::::E       EEEEEE  R::::R     R:::::R  R::::R     R:::::RO::::::O   O::::::O  R::::R     R:::::R");
            Console.WriteLine("\t\t\t\t\t\t  E:::::E               R::::R     R:::::R  R::::R     R:::::RO:::::O     O:::::O  R::::R     R:::::R");
            Console.WriteLine("\t\t\t\t\t\t  E::::::EEEEEEEEEE     R::::RRRRRR:::::R   R::::RRRRRR:::::R O:::::O     O:::::O  R::::RRRRRR:::::R ");
            Console.WriteLine("\t\t\t\t\t\t  E:::::::::::::::E     R:::::::::::::RR    R:::::::::::::RR  O:::::O     O:::::O  R:::::::::::::RR  ");
            Console.WriteLine("\t\t\t\t\t\t  E:::::::::::::::E     R::::RRRRRR:::::R   R::::RRRRRR:::::R O:::::O     O:::::O  R::::RRRRRR:::::R ");
            Console.WriteLine("\t\t\t\t\t\t  E::::::EEEEEEEEEE     R::::R     R:::::R  R::::R     R:::::RO:::::O     O:::::O  R::::R     R:::::R");
            Console.WriteLine("\t\t\t\t\t\t  E:::::E               R::::R     R:::::R  R::::R     R:::::RO:::::O     O:::::O  R::::R     R:::::R");
            Console.WriteLine("\t\t\t\t\t\t  E:::::E       EEEEEE  R::::R     R:::::R  R::::R     R:::::RO::::::O   O::::::O  R::::R     R:::::R");
            Console.WriteLine("\t\t\t\t\t\tEE::::::EEEEEEEE:::::ERR:::::R     R:::::RRR:::::R     R:::::RO:::::::OOO:::::::ORR:::::R     R:::::R");
            Console.WriteLine("\t\t\t\t\t\tE::::::::::::::::::::ER::::::R     R:::::RR::::::R     R:::::R OO:::::::::::::OO R::::::R     R:::::R");
            Console.WriteLine("\t\t\t\t\t\tE::::::::::::::::::::ER::::::R     R:::::RR::::::R     R:::::R   OO:::::::::OO   R::::::R     R:::::R");
            Console.WriteLine("\t\t\t\t\t\tEEEEEEEEEEEEEEEEEEEEEERRRRRRRR     RRRRRRRRRRRRRRR     RRRRRRR     OOOOOOOOO     RRRRRRRR     RRRRRRR");
            Console.WriteLine("\n\n");
            Console.WriteLine("\t\tTTTTTTTTTTTTTTTTTTTTTTT                                                                 AAA                                                       iiii                    ");
            Console.WriteLine("\t\tT:::::::::::::::::::::T                                                                A:::A                                                     i::::i                   ");
            Console.WriteLine("\t\tT:::::::::::::::::::::T                                                               A:::::A                                                     iiii                    ");
            Console.WriteLine("\t\tT:::::TT:::::::TT:::::T                                                              A:::::::A                                                                            ");
            Console.WriteLine("\t\tTTTTTT  T:::::T  TTTTTTrrrrr   rrrrrrrrr   yyyyyyy           yyyyyyy                A:::::::::A              ggggggggg   ggggg  aaaaaaaaaaaaa   iiiiiii nnnn  nnnnnnnn    ");
            Console.WriteLine("\t\t        T:::::T        r::::rrr:::::::::r   y:::::y         y:::::y                A:::::A:::::A            g:::::::::ggg::::g  a::::::::::::a  i:::::i n:::nn::::::::nn  ");
            Console.WriteLine("\t\t        T:::::T        r:::::::::::::::::r   y:::::y       y:::::y                A:::::A A:::::A          g:::::::::::::::::g  aaaaaaaaa:::::a  i::::i n::::::::::::::nn ");
            Console.WriteLine("\t\t        T:::::T        rr::::::rrrrr::::::r   y:::::y     y:::::y                A:::::A   A:::::A        g::::::ggggg::::::gg           a::::a  i::::i nn:::::::::::::::n");
            Console.WriteLine("\t\t        T:::::T         r:::::r     r:::::r    y:::::y   y:::::y                A:::::A     A:::::A       g:::::g     g:::::g     aaaaaaa:::::a  i::::i   n:::::nnnn:::::n");
            Console.WriteLine("\t\t        T:::::T         r:::::r     rrrrrrr     y:::::y y:::::y                A:::::AAAAAAAAA:::::A      g:::::g     g:::::g   aa::::::::::::a  i::::i   n::::n    n::::n");
            Console.WriteLine("\t\t        T:::::T         r:::::r                  y:::::y:::::y                A:::::::::::::::::::::A     g:::::g     g:::::g  a::::aaaa::::::a  i::::i   n::::n    n::::n");
            Console.WriteLine("\t\t        T:::::T         r:::::r                   y:::::::::y                A:::::AAAAAAAAAAAAA:::::A    g::::::g    g:::::g a::::a    a:::::a  i::::i   n::::n    n::::n");
            Console.WriteLine("\t\t      TT:::::::TT       r:::::r                    y:::::::y                A:::::A             A:::::A   g:::::::ggggg:::::g a::::a    a:::::a i::::::i  n::::n    n::::n");
            Console.WriteLine("\t\t      T:::::::::T       r:::::r                     y:::::y                A:::::A               A:::::A   g::::::::::::::::g a:::::aaaa::::::a i::::::i  n::::n    n::::n");
            Console.WriteLine("\t\t      T:::::::::T       r:::::r                    y:::::y                A:::::A                 A:::::A   gg::::::::::::::g  a::::::::::aa:::ai::::::i  n::::n    n::::n");
            Console.WriteLine("\t\t      TTTTTTTTTTT       rrrrrrr                   y:::::y                AAAAAAA                   AAAAAAA    gggggggg::::::g   aaaaaaaaaa  aaaaiiiiiiii  nnnnnn    nnnnnn");
            Console.WriteLine("\t\t                                                 y:::::y                                                              g:::::g                                             ");
            Console.WriteLine("\t\t                                                y:::::y                                                   gggggg      g:::::g                                             ");
            Console.WriteLine("\t\t                                               y:::::y                                                    g:::::gg   gg:::::g                                             ");
            Console.WriteLine("\t\t                                              y:::::y                                                      g::::::ggg:::::::g                                             ");
            Console.WriteLine("\t\t                                             yyyyyyy                                                        gg:::::::::::::g                                              ");
            Console.WriteLine("\t\t                                                                                                              ggg::::::ggg                                                ");
            Console.WriteLine("\t\t                                                                                                                 gggggg                                                   ");
            Console.WriteLine("\n\t\t\t\t\t\t\t\t\t[Error] 잘못된 입력입니다. 다시 입력하세요.");
            Console.ReadLine();
        }   //  ErrorMessage

        public void GameOver()  //  게임종료
        {
            Console.Clear();

            Console.WriteLine("\n\n");
            Console.WriteLine("\tTTTTTTTTTTTTTTTTTTTTTTThhhhhhh                                                 kkkkkkkk");
            Console.WriteLine("\tT:::::::::::::::::::::Th:::::h                                                 k::::::k");
            Console.WriteLine("\tT:::::::::::::::::::::Th:::::h                                                 k::::::k");
            Console.WriteLine("\tT:::::TT:::::::TT:::::Th:::::h                                                 k::::::k");
            Console.WriteLine("\tTTTTTT  T:::::T  TTTTTT h::::h hhhhh         aaaaaaaaaaaaa   nnnn  nnnnnnnn     k:::::k    kkkkkkk     yyyyyyy           yyyyyyy   ooooooooooo   uuuuuu    uuuuuu");
            Console.WriteLine("\t        T:::::T         h::::hh:::::hhh      a::::::::::::a  n:::nn::::::::nn   k:::::k   k:::::k       y:::::y         y:::::y  oo:::::::::::oo u::::u    u::::u");
            Console.WriteLine("\t        T:::::T         h::::::::::::::hh    aaaaaaaaa:::::a n::::::::::::::nn  k:::::k  k:::::k         y:::::y       y:::::y  o:::::::::::::::ou::::u    u::::u");
            Console.WriteLine("\t        T:::::T         h:::::::hhh::::::h            a::::a nn:::::::::::::::n k:::::k k:::::k           y:::::y     y:::::y   o:::::ooooo:::::ou::::u    u::::u");
            Console.WriteLine("\t        T:::::T         h::::::h   h::::::h    aaaaaaa:::::a   n:::::nnnn:::::n k::::::k:::::k             y:::::y   y:::::y    o::::o     o::::ou::::u    u::::u");
            Console.WriteLine("\t        T:::::T         h:::::h     h:::::h  aa::::::::::::a   n::::n    n::::n k:::::::::::k               y:::::y y:::::y     o::::o     o::::ou::::u    u::::u");
            Console.WriteLine("\t        T:::::T         h:::::h     h:::::h a::::aaaa::::::a   n::::n    n::::n k:::::::::::k                y:::::y:::::y      o::::o     o::::ou::::u    u::::u");
            Console.WriteLine("\t        T:::::T         h:::::h     h:::::ha::::a    a:::::a   n::::n    n::::n k::::::k:::::k                y:::::::::y       o::::o     o::::ou:::::uuuu:::::u");
            Console.WriteLine("\t      TT:::::::TT       h:::::h     h:::::ha::::a    a:::::a   n::::n    n::::nk::::::k k:::::k                y:::::::y        o:::::ooooo:::::ou:::::::::::::::uu");
            Console.WriteLine("\t      T:::::::::T       h:::::h     h:::::ha:::::aaaa::::::a   n::::n    n::::nk::::::k  k:::::k                y:::::y         o:::::::::::::::o u:::::::::::::::u");
            Console.WriteLine("\t      T:::::::::T       h:::::h     h:::::h a::::::::::aa:::a  n::::n    n::::nk::::::k   k:::::k              y:::::y           oo:::::::::::oo   uu::::::::uu:::u");
            Console.WriteLine("\t      TTTTTTTTTTT       hhhhhhh     hhhhhhh  aaaaaaaaaa  aaaa  nnnnnn    nnnnnnkkkkkkkk    kkkkkkk            y:::::y              ooooooooooo       uuuuuuuu  uuuu");
            Console.WriteLine("\t                                                                                                             y:::::y");
            Console.WriteLine("\t                                                                                                            y:::::y");
            Console.WriteLine("\t                                                                                                           y:::::y");
            Console.WriteLine("\t                                                                                                          y:::::y");
            Console.WriteLine("\t                                                                                                         yyyyyyy");
            Console.WriteLine("\t    ffffffffffffffff                                                                lllllll                                              iiii");
            Console.WriteLine("\t   f::::::::::::::::f                                                               l:::::l                                             i::::i");
            Console.WriteLine("\t  f::::::::::::::::::f                                                              l:::::l                                              iiii");
            Console.WriteLine("\t  f::::::fffffff:::::f                                                              l:::::l");
            Console.WriteLine("\t  f:::::f       ffffff   ooooooooooo   rrrrr   rrrrrrrrr        ppppp   ppppppppp    l::::l   aaaaaaaaaaaaa   yyyyyyy           yyyyyyyiiiiiii nnnn  nnnnnnnn       ggggggggg   ggggg");
            Console.WriteLine("\t  f:::::f              oo:::::::::::oo r::::rrr:::::::::r       p::::ppp:::::::::p   l::::l   a::::::::::::a   y:::::y         y:::::y i:::::i n:::nn::::::::nn    g:::::::::ggg::::g");
            Console.WriteLine("\t f:::::::ffffff       o:::::::::::::::or:::::::::::::::::r      p:::::::::::::::::p  l::::l   aaaaaaaaa:::::a   y:::::y       y:::::y   i::::i n::::::::::::::nn  g:::::::::::::::::g");
            Console.WriteLine("\t f::::::::::::f       o:::::ooooo:::::orr::::::rrrrr::::::r     pp::::::ppppp::::::p l::::l            a::::a    y:::::y     y:::::y    i::::i nn:::::::::::::::ng::::::ggggg::::::gg");
            Console.WriteLine("\t f::::::::::::f       o::::o     o::::o r:::::r     r:::::r      p:::::p     p:::::p l::::l     aaaaaaa:::::a     y:::::y   y:::::y     i::::i   n:::::nnnn:::::ng:::::g     g:::::g");
            Console.WriteLine("\t f:::::::ffffff       o::::o     o::::o r:::::r     rrrrrrr      p:::::p     p:::::p l::::l   aa::::::::::::a      y:::::y y:::::y      i::::i   n::::n    n::::ng:::::g     g:::::g");
            Console.WriteLine("\t  f:::::f             o::::o     o::::o r:::::r                  p:::::p     p:::::p l::::l  a::::aaaa::::::a       y:::::y:::::y       i::::i   n::::n    n::::ng:::::g     g:::::g");
            Console.WriteLine("\t  f:::::f             o::::o     o::::o r:::::r                  p:::::p    p::::::p l::::l a::::a    a:::::a        y:::::::::y        i::::i   n::::n    n::::ng::::::g    g:::::g");
            Console.WriteLine("\t f:::::::f            o:::::ooooo:::::o r:::::r                  p:::::ppppp:::::::pl::::::la::::a    a:::::a         y:::::::y        i::::::i  n::::n    n::::ng:::::::ggggg:::::g");
            Console.WriteLine("\t f:::::::f            o:::::::::::::::o r:::::r                  p::::::::::::::::p l::::::la:::::aaaa::::::a          y:::::y         i::::::i  n::::n    n::::n g::::::::::::::::g");
            Console.WriteLine("\t f:::::::f             oo:::::::::::oo  r:::::r                  p::::::::::::::pp  l::::::l a::::::::::aa:::a        y:::::y          i::::::i  n::::n    n::::n  gg::::::::::::::g");
            Console.WriteLine("\t fffffffff               ooooooooooo    rrrrrrr                  p::::::pppppppp    llllllll  aaaaaaaaaa  aaaa       y:::::y           iiiiiiii  nnnnnn    nnnnnn    gggggggg::::::g");
            Console.WriteLine("\t                                                                 p:::::p                                            y:::::y                                                  g:::::g");
            Console.WriteLine("\t                                                                 p:::::p                                           y:::::y                                       gggggg      g:::::g");
            Console.WriteLine("\t                                                                p:::::::p                                         y:::::y                                        g:::::gg   gg:::::g");
            Console.WriteLine("\t                                                                p:::::::p                                        y:::::y                                          g::::::ggg:::::::g");
            Console.WriteLine("\t                                                                p:::::::p                                       yyyyyyy                                            gg:::::::::::::g");
            Console.WriteLine("\t                                                                ppppppppp                                                                                            ggg::::::ggg");
        }   //  GameOver

        public void SetupPlayerCharacter(string NAME_, int HP_, int MAXHP_, int STR_, int DEX_, int INT_, int WIS_, int LUCK_, int GOLD_)   //  플레이어 캐릭터 설정
        {
            playerNAME = NAME_;
            playerHP = HP_;
            playerMAXHP = MAXHP_;
            playerSTR = STR_;
            playerDEX = DEX_;
            playerINT = INT_;
            playerWIS = WIS_;
            playerLUCK = LUCK_;
            playerGOLD = GOLD_;

            if (playerHP > playerMAXHP)     //  제한 : 최대체력
            {
                playerHP = playerMAXHP;
            }
        }   //  SetupPlayerCharacter

        public void SetupMonsterCharacter(string NAME_, int HP_, int MAXHP_, int STR_, int DEX_, int INT_, int WIS_, int LUCK_)     //  몬스터 설정
        {
            monsterNAME = NAME_;
            monsterHP = HP_;
            monsterMAXHP = MAXHP_;
            monsterSTR = STR_;
            monsterDEX = DEX_;
            monsterINT = INT_;
            monsterWIS = WIS_;
            monsterLUCK = LUCK_;

        }   //  SetupMonsterCharacter

        public void ATKCalculation()    //  공격력 계산
        {
            playerATK = basicATK + playerSTR + playerINT;
            monsterATK = basicATK + monsterATK;
        }   //  ATKCalculation

        public void DEFCalculation()    //  방어력 계산
        {

        }   //  DEFCalculation

        public void CharacterSelection()    //  캐릭터 선택
        {
            Console.Clear();

            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("\t\t\t\t.|'''', '||                                                                            '||                            ||");
            Console.WriteLine("\t\t\t\t||       ||                                                                             ||                            ||");
            Console.WriteLine("\t\t\t\t|       ||''|, .|''|, .|''|, ('''' .|''|,    '||  ||` .|''|, '||  ||` '||''|    .|'',  ||''|, '||''|  '''|.  .|'', ''||''  .|''|, '||''|");
            Console.WriteLine("\t\t\t\t||       ||  || ||  || ||  ||  `'') ||..||     `|..||  ||  ||  ||  ||   ||       ||     ||  ||  ||    .|''||  ||      ||    ||..||  ||");
            Console.WriteLine("\t\t\t\t`|....' .||  || `|..|' `|..|' `...' `|...          ||  `|..|'  `|..'|. .||.      `|..' .||  || .||.   `|..||. `|..'   `|..' `|...  .||.");
            Console.WriteLine("\t\t\t\t                                                ,  |'");
            Console.WriteLine("\t\t\t\t                                                 ''");
            Console.WriteLine("\t\t");
            Console.WriteLine("\t\t ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓ ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓ ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓ ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓ ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine("\t\t ┃      A D V E N T U R E R     ┃ ┃       K  N  I  G  H  T       ┃ ┃       W  I  Z  A  R  D       ┃ ┃         T  H  I  E  F        ┃ ┃      G  A  M  B  L  E  R     ┃");
            Console.WriteLine("\t\t ┃==============================┃ ┃==============================┃ ┃==============================┃ ┃==============================┃ ┃==============================┃");
            Console.WriteLine("\t\t ┃    ##      @    ,  .   .#    ┃ ┃  ####    = ~    -=$:    ~ *  ┃ ┃  ####           ,#*.         ┃ ┃     ##      -      $    $.   ┃ ┃ ######                   !@, ┃");
            Console.WriteLine("\t\t ┃   ###      !$   !  =   #;    ┃ ┃ ##  ##   #:@ .$@@@.;$#, @:#  ┃ ┃ ##  ##        : ,=:. =       ┃ ┃    ###       ;!    #    $@   ┃ ┃ ##                   = .@@:  ┃");
            Console.WriteLine("\t\t ┃ #####   .-  !.  ;::=  -:  -  ┃ ┃ ##  ##   #@@@!@@@@.   *@@@$  ┃ ┃ ##  ##  :*~--=$  !,  #*--:=- ┃ ┃  #####        *@   # ,;;@@;  ┃ ┃ #####             :-~@:.$@-  ┃");
            Console.WriteLine("\t\t ┃    ##    ~=  @-=@;-@=-@  #~  ┃ ┃   ###    .#@#=@@@@    $$@#.  ┃ ┃    ##    !$#$@   =;  .@##$:  ┃ ┃ ##  ##         @- .$= @@@@@  ┃ ┃     ##            #$@-@@@@@= ┃");
            Console.WriteLine("\t\t ┃    ##    .$ ,$@;!@@:!@*: #   ┃ ┃  ##       -* @*@@@   :@ !-   ┃ ┃ ##  ##    @@=@ . @= - @#@@   ┃ ┃ #######        !=#*=:$!@,@@  ┃ ┃  ## ##         @,:-=:@-@$@~  ┃");
            Console.WriteLine("\t\t ┃    ##     @-@@@@ =$ @@@=-@   ┃ ┃ ##  ##    $- !@!@@  ,@! ,$   ┃ ┃ ##  ##    ,@$@ *$#*$* ##@    ┃ ┃     ##          !.$;,  $ #;- ┃ ┃ ##  ##         #=# @~#;:~@:  ┃");
            Console.WriteLine("\t\t ┃   ####    ;@@@-@,*#:@.@@@-   ┃ ┃ ######    *!  @@!=..@@  !*   ┃ ┃  ####      .@=-.;#@; !=#     ┃ ┃    ####           -@.    ~ - ┃ ┃  ####          @@@$@#:#=@.   ┃");
            Console.WriteLine("\t\t ┃            ! @~;@*;@::@ ;    ┃ ┃           ;~  *#@*:@#*  ~;   ┃ ┃             ~!@,@@@@~@*      ┃ ┃                   !$,      - ┃ ┃                #;= @,;#$@*   ┃");
            Console.WriteLine("\t\t ┃             .:=.@=@@ @~.     ┃ ┃           @@  !@$@.$@;  @@   ┃ ┃              -@#@*=#@@.      ┃ ┃                   *~@.     . ┃ ┃                # , ;,#.; ~   ┃");
            Console.WriteLine("\t\t ┃┌───────────┐   ,@=@@,        ┃ ┃           :~$ .$=!::$. $~;   ┃ ┃               -;#@@$#.       ┃ ┃                   :-@        ┃ ┃                #=# @~!$=     ┃");
            Console.WriteLine("\t\t ┃│ HP   : 80 │   ~@#=@:        ┃ ┃            #@@== #$ =$@@#    ┃ ┃                 -@@          ┃ ┃                   $!-        ┃ ┃                #:= @,-~*!@.  ┃");
            Console.WriteLine("\t\t ┃│ STR  : 3  │    ;@@*         ┃ ┃           .#:#- $;!$ -#:#.   ┃ ┃                 -@@          ┃ ┃                   ;~=        ┃ ┃                @@@$@@;@: -~  ┃");
            Console.WriteLine("\t\t ┃│ DEX  : 3  │  :@#  $@;       ┃ ┃             ~~@@!--!@@~~     ┃ ┃                 ,@@          ┃ ┃                   $*         ┃ ┃                @$#$@#$-,::   ┃");
            Console.WriteLine("\t\t ┃│ WIS  : 3  │ $@;    :@$      ┃ ┃              :* .@@. !:      ┃ ┃                 -@@          ┃ ┃                  ,=          ┃ ┃                 ## =@@ .@    ┃");
            Console.WriteLine("\t\t ┃│ LUCK : 3  │*:        ;=;    ┃ ┃                 !  !         ┃ ┃                 ,@@          ┃ ┃                  =           ┃ ┃                 $=$.. @!     ┃");
            Console.WriteLine("\t\t ┃│ GOLD : 100│                 ┃ ┃                              ┃ ┃                  @@          ┃ ┃                              ┃ ┃                 ,@ $         ┃");
            Console.WriteLine("\t\t ┃└───────────┘                 ┃ ┃                              ┃ ┃                  ;-          ┃ ┃                              ┃ ┃                   #.         ┃");
            Console.WriteLine("\t\t ┃==============================┃ ┃==============================┃ ┃============================= ┃ ┃==============================┃ ┃==============================┃");
            Console.WriteLine("\t\t ┃                              ┃ ┃                              ┃ ┃                              ┃ ┃                              ┃ ┃                              ┃");
            Console.WriteLine("\t\t ┃                              ┃ ┃                              ┃ ┃                              ┃ ┃                              ┃ ┃                              ┃");
            Console.WriteLine("\t\t ┃ During my travels, I entered ┃ ┃                              ┃ ┃                              ┃ ┃                              ┃ ┃                              ┃");
            Console.WriteLine("\t\t ┃ an unkown tower.             ┃ ┃                              ┃ ┃                              ┃ ┃                              ┃ ┃                              ┃");
            Console.WriteLine("\t\t ┃ While running away from many ┃ ┃                              ┃ ┃                              ┃ ┃                              ┃ ┃                              ┃");
            Console.WriteLine("\t\t ┃ monsters, he finds a treasure┃ ┃                              ┃ ┃                              ┃ ┃                              ┃ ┃                              ┃");
            Console.WriteLine("\t\t ┃ and makes a foolish choice...┃ ┃                              ┃ ┃                              ┃ ┃                              ┃ ┃                              ┃");
            Console.WriteLine("\t\t ┃                              ┃ ┃                              ┃ ┃                              ┃ ┃                              ┃ ┃                              ┃");
            Console.WriteLine("\t\t ┃                              ┃ ┃                              ┃ ┃                              ┃ ┃                              ┃ ┃                              ┃");
            Console.WriteLine("\t\t ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛ ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛ ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛ ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛ ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

            Console.Write("\n\n\t\t\t\t\t\t\t\t\t\t캐릭터를 선택하세요 : ");

            int.TryParse(Console.ReadLine(), out userInput);

            switch (userInput)
            {
                case 1:
                    SetupPlayerCharacter("모험가", 80, 80, 3, 3, 0, 3, 3, 100);    //  1번 : Adventurer(모험가) 클래스의 정보
                    EnterScreen();
                    ActionChoice();
                    break;
                case 2:
                    SetupPlayerCharacter("기사", 100, 100, 5, 5, 0, 0, 0, 100);    //  1번 : Knight(기사) 클래스의 정보
                    EnterScreen();
                    ActionChoice();
                    break;
                case 3:
                    SetupPlayerCharacter("마법사", 60, 60, 0, 0, 10, 5, 3, 100);    //  1번 : Wizard(마법사) 클래스의 정보
                    EnterScreen();
                    ActionChoice();
                    break;
                case 4:
                    SetupPlayerCharacter("도적", 70, 70, 3, 1, 0, 2, 2, 150);    //  1번 : Thief(도적) 클래스의 정보
                    EnterScreen();
                    ActionChoice();
                    break;
                case 5:
                    SetupPlayerCharacter("겜블러", 50, 50, 0, 0, 0, 10, 10, 200);    //  1번 : Gambler(겜블러) 클래스의 정보
                    EnterScreen();
                    ActionChoice();
                    break;
                default:
                    ErrorMessage();         //  [ERROR]
                    CharacterSelection();
                    break;
            }

        }   //  CharacterSelection

        public void EnterScreen()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;     //  출력 색갈 설정
            Console.SetCursorPosition(70, 10);  //  출력 위치 설정

            string text = "탑에 들어서자 거대한 문 앞에 어쩌구 저쩌구 ~";

            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);         //  문자열을 한글자씩 출력
                Thread.Sleep(80);               //  출력시간 조절
            }

            Console.ResetColor();   //  출력 색갈 초기화

            Console.ReadLine();
        }   //  EnterScreen

        public void MainUi()
        {
            Console.Clear();

            Console.WriteLine("=======================================================================================================================================================================================================");
            Console.WriteLine($"     직업 : {playerNAME}          ♥ : {playerMAXHP} / {playerHP}                         STR : {playerSTR}  DEX : {playerDEX}  INT : {playerINT}  WIS : {playerWIS}  LUCK : {playerLUCK}                                          GOLD : {playerGOLD}");
            Console.WriteLine("=======================================================================================================================================================================================================");
            Console.WriteLine("                                                                                       보유 아이템                                                                                                      ");
            Console.WriteLine("①\n                                                                                                                                                                                                   ");
            Console.WriteLine("②\n                                                                                                                                                                                                   ");
            Console.WriteLine("③\n                                                                                                                                                                                                   ");
            Console.WriteLine("④\n                                                                                                                                                                                                   ");
            Console.WriteLine("⑤\n                                                                                                                                                                                                   ");
            Console.WriteLine("=======================================================================================================================================================================================================");
            Console.WriteLine("");
            Console.WriteLine("\t@@@@@@@@@@@@@@@@@@ -;~,.,@~@@@@@@@@@@@@@                                                                                                                           ");
            Console.WriteLine("\t@@@@@@@@@@@@@@@@@@-. . ,,, @@@@@@@@@@@@@                                                                                                                           ");
            Console.WriteLine("\t@@@@@@@@@@@@@@@@@@~.  .-~. @@@@@@@@@@@@@                                                                                                                           ");
            Console.WriteLine("\t@@@@@@@@@@@@@@@@@@;~- ..,,.@@@@@@@@@@@@@                                                                                                                           ");
            Console.WriteLine("\t@@@@@@@@@@@@@@@@@-!:..,,~,.@@@@@@@@@@@@@                                                                                                                           ");
            Console.WriteLine("\t@@@@@@@@@@@@@@@  .;*: ,-:~.@@@@@@@@@@@@@                                                                                                                           ");
            Console.WriteLine("\t@@@@@@@@@@@@@ ..  .:!!.-~-@@@@@@@@@@@@@@                                                                                                                          ");
            Console.WriteLine("\t@@@@@@@@@@@.    .  .;;*;;,@@@@@@@@@@@@@@                                                                                                                           ");
            Console.WriteLine("\t@@@@@@@@@@@.  ....  ,:;:.,-@@@@@@@@@@@@@                                                                                                                           ");
            Console.WriteLine("\t@@@@@@@@@@.,:~ ...    -.,.~@@@@@@@@@@@@@                                                                                                                           ");
            Console.WriteLine("\t@@@@@@@@@@:--~;;.    . ,,-~@@@@@@@@@@@@@                                                                                                                          ");
            Console.WriteLine("\t@@@@@@@@@. .~:**:,  ...,,!;@@@@@@@@@@@@@                                                                                                                           ");
            Console.WriteLine("\t@@@@@@@@@  ,:@;*. ,....,,:*:@@@@@@@@@@@@                                                                                                                           ");
            Console.WriteLine("\t@@@@@@@@~ .-@@~! ,-,...,::~:@@@@@@@@@@@@                                                                                                                           ");
            Console.WriteLine("\t@@@@@@@@  ,@@@@. ,,-~..-;--. @@@@@@@@@@@                                                                                                                           ");
            Console.WriteLine("\t@@@@@@@  ,@@.~.  ,,---.!: ., .@@@@@@@@@@                                                                                                                           ");
            Console.WriteLine("\t@@@@@@  .-, .  .., -~-,..~ ,,  @@@@@@@@@                                                                                                                           ");
            Console.WriteLine("\t@@@@@@ .~,,   ...@@.. .. ,-@..  @@@@@@@@                                                                                                                           ");
            Console.WriteLine("\t@@@@@@ ,,,   ..--@@@@@,...,-@@, .@@@@@@@                                                                                                                           ");
            Console.WriteLine("\t@@@@@@@@@... .,.@@@@@@-,...,.@@... @@@@@                                                                                                                           ");
            Console.WriteLine("\t@@@@@@@@@    .,.@@@@@@.,..... @ ,.,@@@@@                                                                                                                           ");
            Console.WriteLine("\t@@@@@@@ .   .,@@@@@@@@::-,.... .:~@@@@@@                                                                                                                           ");
            Console.WriteLine("\t@@@@@@@.   ,:@@@@@@@@@@@@@~~,..-..@@@@@@                                                                                                                           ");
            Console.WriteLine("\t@@@@@@@- .~~@@@@@@@@@@@@@@@@ ...~@@@@@@@                                                                                                                           ");
            Console.WriteLine("\t@@@@@@@~. -@@@@@@@@@@@@@@@@@ ...-@@@@@@@                                                                                                                           ");
            Console.WriteLine("\t@@@@@@@~. @@@@@@@@@@@@@@@@@@@-...@@@@@@@                                                                                                                           ");
            Console.WriteLine("\t@@@@@@@~.-;@@@@@@@@@@@@@@@@@@@~-. @@@@@@                                                                                                                           ");
            Console.WriteLine("\t@@@@@@@@.~@@@@@@@@@@@@@@@@@@@@@~,~@@@@@@                                                                                                                           ");
            Console.WriteLine("\t@@@@@@@@ ~@@@@@@@@@@@@@@@@@@@@@@~-@@@@@@                                                                                                                           ");
            Console.WriteLine("\t@@@@@@@.,,@@@@@@@@@@@@@@@@@@@@@@.,,@@@@@                                                                                                                           ");
            Console.WriteLine("\t@@@@@@..,.:@@@@@@@@@@@@@@@@@@@@@$,.. @@@                                                                                                                           ");
            Console.WriteLine("\t@@@@@@=:$@=@@@@@@@@@@@@@@@@@@@@@#::#!@@@                                                                                                                           ");

        }   //  MainUi

        public void ActionChoice()
        {
            Console.Clear();

            MainUi();

            Console.SetCursorPosition(120, 20);     //  출력 위치 설정
            Console.Write("행동을 선택하세요 : ");

            list.Add(1);
            list.Add(2);
            list.Add(3);

            foreach (var n in list)
            {
                switch (n)
                {
                    case 1:
                        Console.SetCursorPosition(110, 25);     //  출력 위치 설정
                        Console.WriteLine($"[{number1}] 탑을 올라갑니다.");
                        break;
                    case 2:
                        Console.SetCursorPosition(110, 30);     //  출력 위치 설정
                        Console.WriteLine($"[{number2}] 수상한 방에 들어갑니다.");
                        break;
                    case 3:
                        Console.SetCursorPosition(110, 35);     //  출력 위치 설정
                        Console.WriteLine($"[{number3}] 휴식을 취합니다.");
                        break;
                }
            }

            Console.SetCursorPosition(150, 20);     //  출력 위치 설정
            int.TryParse(Console.ReadLine(), out userInput);

            if (userInput == 1)
            {
                BattleScreen();
            }
            else if (userInput == 2)
            {

                list.Remove(2);     //  2번 선택시 선택지 제거
                number3 = 2;
            }
            else if (userInput == 3)
            {
                Rest();
                list.Remove(3);     //  3번 선택시 선택지 제거
            }
            else
            {
                ErrorMessage();     //  [ERROR]
                ActionChoice();
            }

            Console.Clear();

            MainUi();

            Console.SetCursorPosition(120, 20);     //  출력 위치 설정
            Console.Write("행동을 선택하세요 : ");

            foreach (var n in list)
            {
                switch (n)
                {
                    case 1:
                        Console.SetCursorPosition(110, 25);     //  출력 위치 설정

                        Console.WriteLine($"[{number1}] 탑을 올라갑니다.");
                        break;
                    case 2:
                        Console.SetCursorPosition(110, 30);     //  출력 위치 설정

                        Console.WriteLine($"[{number2}] 수상한 방에 들어갑니다.");
                        break;
                    case 3:
                        Console.SetCursorPosition(110, 35);     //  출력 위치 설정

                        Console.WriteLine($"[{number3}] 휴식을 취합니다.");
                        break;
                }
            }

            Console.SetCursorPosition(150, 20);     //  출력 위치 설정
            int.TryParse(Console.ReadLine(), out userInput);

        }   //  ActionChoice

        public void Rest()
        {
            Console.Clear();

            int percent = random.Next(1, 4);

            if (percent == 1)
            {
                Console.WriteLine("휴식을 취하던 도중 적의 습격을 받았습니다. {HP - 10}");    //  33%의 확률로 체력을 회복하는 대신 잃음
                playerHP = playerHP - 10;
            }
            else
            {
                Console.WriteLine("상쾌함을 느낍니다. {HP + 10}");

                if (playerHP + 10 >= playerMAXHP)   //  제한 : 체력은 최대체력보다 높을수 없음
                {
                    playerHP = playerMAXHP;
                }
                else
                {
                    playerHP += 10;
                }
            }
            Console.ReadLine();


        }







        public void Event()     //  Event
        {
            //  여기서 이벤트 종류와 확률 등을 설정
        }   //  Event


        public void NormalMonster()     //  Event : NormalMonster
        {
            switch (random.Next(1, 11))
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                default:
                    break;
            }

        }   //  NormalMonster





















        public void BattleScreen()
        {
            Console.Clear();

            BattleUi_Cultist();

            Console.SetCursorPosition(90, 20);
            Console.WriteLine("행동을 선택하세요");

            Console.SetCursorPosition(90, 23);
            Console.WriteLine("가나다라마바사");

            Console.SetCursorPosition(90, 26);
            Console.WriteLine("가나다라마바사");

            Console.SetCursorPosition(90, 29);
            Console.WriteLine("가나다라마바사");

            Console.ReadLine();

        }

        public void BattleAction()
        {

        }




        public void BattleUi_Cultist()
        {
            Console.WriteLine("=======================================================================================================================================================================================================");
            Console.WriteLine($"     직업 : {playerNAME}          ♥ : {playerMAXHP} / {playerHP}                         STR : {playerSTR}  DEX : {playerDEX}  INT : {playerINT}  WIS : {playerWIS}  LUCK : {playerLUCK}                                          GOLD : {playerGOLD}");
            Console.WriteLine("=======================================================================================================================================================================================================");
            Console.WriteLine("                                                                                       보유 아이템                                                                                                      ");
            Console.WriteLine("①\n                                                                                                                                                                                                   ");
            Console.WriteLine("②\n                                                                                                                                                                                                   ");
            Console.WriteLine("③\n                                                                                                                                                                                                   ");
            Console.WriteLine("④\n                                                                                                                                                                                                   ");
            Console.WriteLine("⑤\n                                                                                                                                                                                                   ");
            Console.WriteLine("=======================================================================================================================================================================================================");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\t■■■■■■■■■■■■■■■  ♥ {playerMAXHP} / {playerHP}                                                                                                      ■■■■■■■■■■■■■■■  ♥ {monsterMAXHP} / {monsterHP}\n");
            Console.WriteLine($"                                                                                                                                                                 {monsterNAME}");
            Console.ResetColor();
            Console.WriteLine("\t@@@@@@@@@@@@@@@@@@ -;~,.,@~@@@@@@@@@@@@@                                                                                                      ##@#*$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@          ");
            Console.WriteLine("\t@@@@@@@@@@@@@@@@@@-. . ,,, @@@@@@@@@@@@@                                                                                                      @@@@**#@@@@@@@@@@@@@@@@@@@@@@@@@@@**=@@@          ");
            Console.WriteLine("\t@@@@@@@@@@@@@@@@@@~.  .-~. @@@@@@@@@@@@@                                                                                                      *@@@=*#@@@@@@@@@@@@@@@@@@@@@@@@@@@##;=@@          ");
            Console.WriteLine("\t@@@@@@@@@@@@@@@@@@;~- ..,,.@@@@@@@@@@@@@                                                                                                      =$@@$*#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#:#@          ");
            Console.WriteLine("\t@@@@@@@@@@@@@@@@@-!:..,,~,.@@@@@@@@@@@@@                                                                                                      @=#@=*#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@!!#          ");
            Console.WriteLine("\t@@@@@@@@@@@@@@@  .;*: ,-:~.@@@@@@@@@@@@@                                                                                                      @==#;*#@@@@@=#@@@@@@@@@@@@@@@@@@@*@@@**#          ");
            Console.WriteLine("\t@@@@@@@@@@@@@ ..  .:!!.-~-@@@@@@@@@@@@@@                                                                                                      @@*=!#@@@@@$!!#@@@@@@@@@@@@@@@@@@*#@@;*#          ");
            Console.WriteLine("\t@@@@@@@@@@@.    .  .;;*;;,@@@@@@@@@@@@@@                                                                                                      @@=*$#@@@=!;!~..*@@@@@@@@@@@@@@@@=#@@;$@          ");
            Console.WriteLine("\t@@@@@@@@@@@.  ....  ,:;:.,-@@@@@@@@@@@@@                                                                                                      @@@*#@@@@*!!.   .#@@@@@@@@@@@@@@==#@;*#@          ");
            Console.WriteLine("\t@@@@@@@@@@.,:~ ...    -.,.~@@@@@@@@@@@@@                                                                                                      @@@==*@@*!!. .   ;#@@@@@@@@@$$#$!=$;;#@@          ");
            Console.WriteLine("\t@@@@@@@@@@:--~;;.    . ,,-~@@@@@@@@@@@@@                                                                                                      @@@@!;#**!; .!. .,::#@@@@@@=~:~:::;;*#@@          ");
            Console.WriteLine("\t@@@@@@@@@. .~:**:,  ...,,!;@@@@@@@@@@@@@                                                                                                      @@@@!:;;!!,......,-*=#@@@;=;~~~~~::!=#@@          ");
            Console.WriteLine("\t@@@@@@@@@  ,:@;*. ,....,,:*:@@@@@@@@@@@@                                                                                                      @@@@*!!::~..;;,~--~;!!;!;:~~~~~~:::!##@@          ");
            Console.WriteLine("\t@@@@@@@@~ .-@@~! ,-,...,::~:@@@@@@@@@@@@                                                                                                      @@@@===!;..~;~~;:;:;;::~~:~~:~~~:::~:##@          ");
            Console.WriteLine("\t@@@@@@@@  ,@@@@. ,,-~..-;--. @@@@@@@@@@@                                                                                                      @@@@**!;!-!;~~:::;;;:~---~~~~~-;:~::::*#          ");
            Console.WriteLine("\t@@@@@@@  ,@@.~.  ,,---.!: ., .@@@@@@@@@@                                                                                                      @@@@!!!!;!;:!;:::::;:---~~~~~~~;~~~~~~;;          ");
            Console.WriteLine("\t@@@@@@  .-, .  .., -~-,..~ ,,  @@@@@@@@@                                                                                                      @@@@=;;!;!!!#*;::;:;;~~:*:~~~~:;~~~~~::!          ");
            Console.WriteLine("\t@@@@@@ .~,,   ...@@.. .. ,-@..  @@@@@@@@                                                                                                      @@@@*;!!*=####;::;:;;;:;#*;:~:~~:~::::;$          ");
            Console.WriteLine("\t@@@@@@ ,,,   ..--@@@@@,...,-@@, .@@@@@@@                                                                                                      @@@@*=#=#$#@@;;;:;;:::;!#@!=;:::::::~::*          ");
            Console.WriteLine("\t@@@@@@@@@... .,.@@@@@@-,...,.@@... @@@@@                                                                                                      @@@@@#@##@@@@!;;:;;;:::!#@@#$#***:~::*=#          ");
            Console.WriteLine("\t@@@@@@@@@    .,.@@@@@@.,..... @ ,.,@@@@@                                                                                                      @@@@@@@@@@@@@;;;:::;;::;#@@@@@@#@;!::!$#          ");
            Console.WriteLine("\t@@@@@@@ .   .,@@@@@@@@::-,.... .:~@@@@@@                                                                                                      @@@@@@@@@@@@@*;;:;;;;;;:$@@@@@@@@@#=###@          ");
            Console.WriteLine("\t@@@@@@@.   ,:@@@@@@@@@@@@@~~,..-..@@@@@@                                                                                                      @@@@@@@@@@@@;;;::;;;;;;;=#@@@@@@@@@@@#@@          ");
            Console.WriteLine("\t@@@@@@@- .~~@@@@@@@@@@@@@@@@ ...~@@@@@@@                                                                                                      @@@@@@@@@@@@*;;::;;::;:;;#@@@@@@@@@@@@@@          ");
            Console.WriteLine("\t@@@@@@@~. -@@@@@@@@@@@@@@@@@ ...-@@@@@@@                                                                                                      @@@@@@@@@@@@=;:;:::::;::*#@@@@@@@@@@@@@@          ");
            Console.WriteLine("\t@@@@@@@~. @@@@@@@@@@@@@@@@@@@-...@@@@@@@                                                                                                      @@@@@@@@@@@*;;::;::;:;;:#@@@@@@@@@@@@@@@          ");
            Console.WriteLine("\t@@@@@@@~.-;@@@@@@@@@@@@@@@@@@@~-. @@@@@@                                                                                                      @@@@@@@@@@@!:::;;;;;::::;#@@@@@@@@@@@@@@          ");
            Console.WriteLine("\t@@@@@@@@.~@@@@@@@@@@@@@@@@@@@@@~,~@@@@@@                                                                                                      @@@@@@@@@@!:;;:;:;::::::;=@@@@@=@@@@@@@@          ");
            Console.WriteLine("\t@@@@@@@@ ~@@@@@@@@@@@@@@@@@@@@@@~-@@@@@@                                                                                                      @@@@@@@@@@==;;;:;:;;::;;;!#;!:;;#@@@@@@@          ");
            Console.WriteLine("\t@@@@@@@.,,@@@@@@@@@@@@@@@@@@@@@@.,,@@@@@                                                                                                      @@@@@@@@@@@=;::!;;!*;;;;:;;;;;=##@@@@@@@          ");
            Console.WriteLine("\t@@@@@@..,.:@@@@@@@@@@@@@@@@@@@@@$,.. @@@                                                                                                      @@@@@@@@@@@@#=~*!=#*~!*=;;;;*=#@@@@@@@@@          ");
            Console.WriteLine("\t@@@@@@=:$@=@@@@@@@@@@@@@@@@@@@@@#::#!@@@                                                                                                      @@@@@@@@@@@@@@~*###=-;###==###@@@@@@@@@@          ");
        }
















        //public void ActionChoice_()
        //{
        //    Console.WriteLine("\n");
        //    Console.WriteLine("\t@@@@@@@@@@@@@@@@@@@@@@@~@@@@@@@@@@@@@@@@                                                                                          ");
        //    Console.WriteLine("\t@@@@@@@@@@@@@@@@@@ -;~,.,@~@@@@@@@@@@@@@                                                                                          ");
        //    Console.WriteLine("\t@@@@@@@@@@@@@@@@@@-. . ,,, @@@@@@@@@@@@@                                                                                          ");
        //    Console.WriteLine("\t@@@@@@@@@@@@@@@@@@~.  .-~. @@@@@@@@@@@@@                                                                                          ");
        //    Console.WriteLine("\t@@@@@@@@@@@@@@@@@@;~- ..,,.@@@@@@@@@@@@@                                                                                          ");
        //    Console.WriteLine("\t@@@@@@@@@@@@@@@@@-!:..,,~,.@@@@@@@@@@@@@                                                                                          ");
        //    Console.WriteLine("\t@@@@@@@@@@@@@@@  .;*: ,-:~.@@@@@@@@@@@@@                                                                                          ");
        //    Console.WriteLine("\t@@@@@@@@@@@@@ ..  .:!!.-~-@@@@@@@@@@@@@@                                               행동을 선택하세요                            ");
        //    Console.WriteLine("\t@@@@@@@@@@@.    .  .;;*;;,@@@@@@@@@@@@@@                                                                                          ");
        //    Console.WriteLine("\t@@@@@@@@@@@.  ....  ,:;:.,-@@@@@@@@@@@@@                                         {1}\t탑을 올라간다.                                ");
        //    Console.WriteLine("\t@@@@@@@@@@.,:~ ...    -.,.~@@@@@@@@@@@@@                                                                                          ");
        //    Console.WriteLine("\t@@@@@@@@@@:--~;;.    . ,,-~@@@@@@@@@@@@@                                         {2}\t수상한 방에 들어간다.                         ");
        //    Console.WriteLine("\t@@@@@@@@@. .~:**:,  ...,,!;@@@@@@@@@@@@@                                                                                          ");
        //    Console.WriteLine("\t@@@@@@@@@  ,:@;*. ,....,,:*:@@@@@@@@@@@@                                         {3}\t휴식을 취한다.                                ");
        //    Console.WriteLine("\t@@@@@@@@~ .-@@~! ,-,...,::~:@@@@@@@@@@@@                                                                                          ");
        //    Console.WriteLine("\t@@@@@@@@  ,@@@@. ,,-~..-;--. @@@@@@@@@@@                                                                                          ");
        //    Console.WriteLine("\t@@@@@@@  ,@@.~.  ,,---.!: ., .@@@@@@@@@@                                                                                          ");
        //    Console.WriteLine("\t@@@@@@  .-, .  .., -~-,..~ ,,  @@@@@@@@@                                                                                          ");
        //    Console.WriteLine("\t@@@@@@ .~,,   ...@@.. .. ,-@..  @@@@@@@@                                                                                          ");
        //    Console.WriteLine("\t@@@@@@ ,,,   ..--@@@@@,...,-@@, .@@@@@@@                                                                                          ");
        //    Console.WriteLine("\t@@@@@@@@@... .,.@@@@@@-,...,.@@... @@@@@                                                                                          ");
        //    Console.WriteLine("\t@@@@@@@@@    .,.@@@@@@.,..... @ ,.,@@@@@                                                                                          ");
        //    Console.WriteLine("\t@@@@@@@ .   .,@@@@@@@@::-,.... .:~@@@@@@                                                                                          ");
        //    Console.WriteLine("\t@@@@@@@.   ,:@@@@@@@@@@@@@~~,..-..@@@@@@                                                                                          ");
        //    Console.WriteLine("\t@@@@@@@- .~~@@@@@@@@@@@@@@@@ ...~@@@@@@@                                                                                          ");
        //    Console.WriteLine("\t@@@@@@@~. -@@@@@@@@@@@@@@@@@ ...-@@@@@@@                                                                                          ");
        //    Console.WriteLine("\t@@@@@@@~. @@@@@@@@@@@@@@@@@@@-...@@@@@@@                                                                                          ");
        //    Console.WriteLine("\t@@@@@@@~.-;@@@@@@@@@@@@@@@@@@@~-. @@@@@@                                                                                          ");
        //    Console.WriteLine("\t@@@@@@@@.~@@@@@@@@@@@@@@@@@@@@@~,~@@@@@@                                                                                          ");
        //    Console.WriteLine("\t@@@@@@@@ ~@@@@@@@@@@@@@@@@@@@@@@~-@@@@@@                                                                                          ");
        //    Console.WriteLine("\t@@@@@@@.,,@@@@@@@@@@@@@@@@@@@@@@.,,@@@@@                                                                                          ");
        //    Console.WriteLine("\t@@@@@@..,.:@@@@@@@@@@@@@@@@@@@@@$,.. @@@                                                                                          ");
        //    Console.WriteLine("\t@@@@@@=:$@=@@@@@@@@@@@@@@@@@@@@@#::#!@@@                                                                                          ");
        //    Console.WriteLine("\t@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@                                                                                          ");

        //int.TryParse(Console.ReadLine(), out userInput);

        //    switch (userInput)
        //    {
        //        case 1:
        //            Event_NormalMonster();
        //            break;
        //        case 2:
        //            Event();
        //            break;
        //        case 3:
        //            if (HP <= max_HP - 10)
        //            {
        //                HP += 10;
        //            }
        //            else if (HP >= max_HP - 10)
        //            {
        //                HP = max_HP;
        //            }
        //            else
        //            {
        //                HP += 0;
        //            }
        //            break;
        //        default:
        //            //ErrorMessage();
        //            break;
        //    }
        //}   //  ActionChoice



        //public void Event()
        //{
        //    int randomEvent = random.Next(1, 2);

        //    switch (randomEvent)
        //    {
        //        case 1:
        //            break;
        //        case 2:
        //            break;
        //        case 3:
        //            break;
        //        case 4:
        //            break;
        //        case 5:
        //            break;
        //        default:
        //            break;
        //    }
        //}

        //public void Event_NormalMonster()   //  이벤트_일반 몬스터
        //{
        //    int randomNormalMonster = random.Next(1, 2);

        //    switch (randomNormalMonster)
        //    {
        //        case 1:
        //            monsterNAME = "광신자(Cultist)";
        //            monstermax_HP = 40;
        //            monsterHP = monstermax_HP;
        //            monsterSTR = 3;
        //            monsterDEX = 3;
        //            monsterOP = 5 + STR;
        //            monsterDP = 3 + DEX;
        //            BattleScreen();
        //            break;
        //        case 2:
        //            break;
        //        case 3:
        //            break;
        //        case 4:
        //            break;
        //        case 5:
        //            break;
        //        case 6:
        //            break;
        //        case 7:
        //            break;
        //        case 8:
        //            break;
        //        case 9:
        //            break;
        //        case 10:
        //            break;
        //        default:
        //            break;
        //    }
        //}

        //public void Event_EliteMonster()    //  이벤트_엘리트 몬스터
        //{

        //}

        //public void Event_BossMonster()     //  이벤트_보스 몬스터
        //{

        //}

        //public void MonsterInformation()
        //{
        //    Console.WriteLine("\n\n\n\n\n\n\n\n");
        //    Console.WriteLine($"{monsterNAME} ♥ : {monstermax_HP} / {monsterHP}");
        //}     

        //public void MyTurn()
        //{
        //    Console.Write("행동 선택 {1 공격} {2 방어} {3 도망} : ");

        //    int.TryParse(Console.ReadLine(), out userInput);

        //    switch (userInput)
        //    {
        //        case 1:
        //            Console.WriteLine("공격함");
        //            monsterHP = monsterHP - (monsterDP - AP);
        //            MonsterInformation();
        //            break;
        //        case 2:
        //            Console.WriteLine("방어함");

        //            break;
        //        case 3:
        //            Console.WriteLine("도망침");
        //            break;
        //        default:
        //            break;
        //    }
        //}

        //public void Battle()
        //{

        //    Console.WriteLine("조우함");

        //    int monsterAction = random.Next(1, 3);

        //    switch (monsterAction)
        //    {
        //        case 1:
        //            Console.WriteLine("공격할거임");
        //            MyTurn();
        //            HP = HP - (DP - monsterOP);
        //            BattleScreen();
        //            break;
        //        case 2:
        //            Console.WriteLine("방어할거임");
        //            MyTurn();
        //            break;
        //        default:
        //            break;
        //    }


        //}

        //public void BattleScreen()
        //{
        //    Console.Clear();

        //    Console.WriteLine("\n\n");

        //    Battle();
        //}





















        public void NormalMonster_Cultist()
        {
            Console.WriteLine("                                                                                                            \t=***=#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("                                                                                                            \t##@#*$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("                                                                                                            \t@@@@**#@@@@@@@@@@@@@@@@@@@@@@@@@@@**=@@@");
            Console.WriteLine("                                                                                                            \t*@@@=*#@@@@@@@@@@@@@@@@@@@@@@@@@@@##;=@@");
            Console.WriteLine("                                                                                                            \t=$@@$*#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#:#@");
            Console.WriteLine("                                                                                                            \t@=#@=*#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@!!#");
            Console.WriteLine("                                                                                                            \t@==#;*#@@@@@=#@@@@@@@@@@@@@@@@@@@*@@@**#");
            Console.WriteLine("                                                                                                            \t@@*=!#@@@@@$!!#@@@@@@@@@@@@@@@@@@*#@@;*#");
            Console.WriteLine("                                                                                                            \t@@=*$#@@@=!;!~..*@@@@@@@@@@@@@@@@=#@@;$@");
            Console.WriteLine("                                                                                                            \t@@@*#@@@@*!!.   .#@@@@@@@@@@@@@@==#@;*#@");
            Console.WriteLine("                                                                                                            \t@@@==*@@*!!. .   ;#@@@@@@@@@$$#$!=$;;#@@");
            Console.WriteLine("                                                                                                            \t@@@@!;#**!; .!. .,::#@@@@@@=~:~:::;;*#@@");
            Console.WriteLine("                                                                                                            \t@@@@!:;;!!,......,-*=#@@@;=;~~~~~::!=#@@");
            Console.WriteLine("                                                                                                            \t@@@@*!!::~..;;,~--~;!!;!;:~~~~~~:::!##@@");
            Console.WriteLine("                                                                                                            \t@@@@===!;..~;~~;:;:;;::~~:~~:~~~:::~:##@");
            Console.WriteLine("                                                                                                            \t@@@@**!;!-!;~~:::;;;:~---~~~~~-;:~::::*#");
            Console.WriteLine("                                                                                                            \t@@@@!!!!;!;:!;:::::;:---~~~~~~~;~~~~~~;;");
            Console.WriteLine("                                                                                                            \t@@@@=;;!;!!!#*;::;:;;~~:*:~~~~:;~~~~~::!");
            Console.WriteLine("                                                                                                            \t@@@@*;!!*=####;::;:;;;:;#*;:~:~~:~::::;$");
            Console.WriteLine("                                                                                                            \t@@@@*=#=#$#@@;;;:;;:::;!#@!=;:::::::~::*");
            Console.WriteLine("                                                                                                            \t@@@@@#@##@@@@!;;:;;;:::!#@@#$#***:~::*=#");
            Console.WriteLine("                                                                                                            \t@@@@@@@@@@@@@;;;:::;;::;#@@@@@@#@;!::!$#");
            Console.WriteLine("                                                                                                            \t@@@@@@@@@@@@@*;;:;;;;;;:$@@@@@@@@@#=###@");
            Console.WriteLine("                                                                                                            \t@@@@@@@@@@@@;;;::;;;;;;;=#@@@@@@@@@@@#@@");
            Console.WriteLine("                                                                                                            \t@@@@@@@@@@@@*;;::;;::;:;;#@@@@@@@@@@@@@@");
            Console.WriteLine("                                                                                                            \t@@@@@@@@@@@@=;:;:::::;::*#@@@@@@@@@@@@@@");
            Console.WriteLine("                                                                                                            \t@@@@@@@@@@@*;;::;::;:;;:#@@@@@@@@@@@@@@@");
            Console.WriteLine("                                                                                                            \t@@@@@@@@@@@!:::;;;;;::::;#@@@@@@@@@@@@@@");
            Console.WriteLine("                                                                                                            \t@@@@@@@@@@!:;;:;:;::::::;=@@@@@=@@@@@@@@");
            Console.WriteLine("                                                                                                            \t@@@@@@@@@@==;;;:;:;;::;;;!#;!:;;#@@@@@@@");
            Console.WriteLine("                                                                                                            \t@@@@@@@@@@@=;::!;;!*;;;;:;;;;;=##@@@@@@@");
            Console.WriteLine("                                                                                                            \t@@@@@@@@@@@@#=~*!=#*~!*=;;;;*=#@@@@@@@@@");
            Console.WriteLine("                                                                                                            \t@@@@@@@@@@@@@@~*###=-;###==###@@@@@@@@@@");
            Console.WriteLine("                                                                                                            \t@@@@@@@@@@@@@@~*#@@@--#@@@#@@@@@@@@@@@@@");
            Console.WriteLine("                                                                                                            \t@@@@@@@@@@@@@@:*#@@@=~~:#@@@@@@@@@@@@@@@");
            Console.WriteLine("                                                                                                            \t@@@@@@@@@@@@@::*#@@=:~#;;@@@@@@@@@@@@@@@");

        }









        //public void Event_MysteryMerchant() //  이벤트_수수께끼 상인
        //{

        //}

        //public void Event_Rest()    //  이벤트_휴식
        //{

        //}































































        //public void Cards()
        //{
        //    /*
        //     * 총 30장 생성
        //     * 기본 공격카드, 기본 방어카드 각 5장씩 총 10장
        //     * 특수 공격카드, 특수 방어카드 7장씩 총 14장
        //     * 스킬카드 6장
        //     */

        //    for (int i = 0; i < 10; i++)
        //    {
        //        card[i] = i;
        //    }

        //    var deckIndex = card.OrderBy(x => random.Next()).ToArray();

        //    foreach (var n in deckIndex)
        //    {
        //        Card newcard = new Card();
        //        switch (deckIndex[n])
        //        {
        //            case 0:
        //                newcard.SetupOneCard("타격", 5, 0, 1);
        //                my_deck.Add(newcard);
        //                break;
        //            case 1:
        //                newcard.SetupOneCard("타격", 5, 0, 1);
        //                my_deck.Add(newcard);
        //                break;
        //            case 2:
        //                newcard.SetupOneCard("타격", 5, 0, 1);
        //                my_deck.Add(newcard);
        //                break;
        //            case 3:
        //                newcard.SetupOneCard("타격", 5, 0, 1);
        //                my_deck.Add(newcard);
        //                break;
        //            case 4:
        //                newcard.SetupOneCard("타격", 5, 0, 1);
        //                my_deck.Add(newcard);
        //                break;
        //            case 5:
        //                newcard.SetupOneCard("수비", 0, 5, 1);
        //                my_deck.Add(newcard);
        //                break;
        //            case 6:
        //                newcard.SetupOneCard("수비", 0, 5, 1);
        //                my_deck.Add(newcard);
        //                break;
        //            case 7:
        //                newcard.SetupOneCard("수비", 0, 5, 1);
        //                my_deck.Add(newcard);
        //                break;
        //            case 8:
        //                newcard.SetupOneCard("수비", 0, 5, 1);
        //                my_deck.Add(newcard);
        //                break;
        //            case 9:
        //                newcard.SetupOneCard("수비", 0, 5, 1);
        //                my_deck.Add(newcard);
        //                break;
        //            default:
        //                break;
        //        }
        //    }
        //}   //  Cards

        //public void Deck()
        //{
        //    my_deck = new List<Card>();
        //    Cards();

        //}

        //public void my_Deck()
        //{
        //    Card my_deck = new Card();
        //}









        //public void SetupOneCard(string cardNAME_, int cardSTR_, int cardDEX_, int cardAP_)
        //{
        //    cardNAME = cardNAME_;
        //    cardSTR = cardSTR_;
        //    cardDEX = cardDEX_;
        //    cardAP = cardAP_;

        //    Console.WriteLine($"내가 뽑은 카드");
        //    Console.WriteLine($"이름        : {cardNAME}");
        //    Console.WriteLine($"공격력      : {cardSTR}");
        //    Console.WriteLine($"방어력      : {cardDEX}");
        //    Console.WriteLine($"소모 헹동력 : {cardAP}");
        //    Console.WriteLine("");
        //}

        //public void MyDeck()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        cards.Add(i);

        //        switch (cards[i])
        //        {
        //            case 0:
        //                SetupOneCard("타격", 5, 0, 1);
        //                break;
        //            case 1:
        //                SetupOneCard("타격", 5, 0, 1);
        //                break;
        //            case 2:
        //                SetupOneCard("타격", 5, 0, 1);
        //                break;
        //            case 3:
        //                SetupOneCard("타격", 5, 0, 1);
        //                break;
        //            case 4:
        //                SetupOneCard("타격", 5, 0, 1);
        //                break;
        //            case 5:
        //                SetupOneCard("수호", 0, 5, 1);
        //                break;
        //            case 6:
        //                SetupOneCard("수호", 0, 5, 1);
        //                break;
        //            case 7:
        //                SetupOneCard("수호", 0, 5, 1);
        //                break;
        //            case 8:
        //                SetupOneCard("수호", 0, 5, 1);
        //                break;
        //            case 9:
        //                SetupOneCard("수호", 0, 5, 1);
        //                break;
        //            default:
        //                break;
        //        }
        //    }
        //}   //  MyDeck

        //public void ShuffleMyDeck()
        //{
        //    var shuffleDeck = cards.OrderBy(x => random.Next()).ToArray();

        //    foreach (var n in shuffleDeck)
        //    {
        //        switch (shuffleDeck[n])
        //        {
        //            case 0:
        //                SetupOneCard("타격", 5, 0, 1);
        //                break;
        //            case 1:
        //                SetupOneCard("타격", 5, 0, 1);
        //                break;
        //            case 2:
        //                SetupOneCard("타격", 5, 0, 1);
        //                break;
        //            case 3:
        //                SetupOneCard("타격", 5, 0, 1);
        //                break;
        //            case 4:
        //                SetupOneCard("타격", 5, 0, 1);
        //                break;
        //            case 5:
        //                SetupOneCard("수호", 0, 5, 1);
        //                break;
        //            case 6:
        //                SetupOneCard("수호", 0, 5, 1);
        //                break;
        //            case 7:
        //                SetupOneCard("수호", 0, 5, 1);
        //                break;
        //            case 8:
        //                SetupOneCard("수호", 0, 5, 1);
        //                break;
        //            case 9:
        //                SetupOneCard("수호", 0, 5, 1);
        //                break;
        //            default:
        //                break;
        //        }
        //    }
        //}

        //public void Test()
        //{
        //    MyDeck();
        //    ShuffleMyDeck();
        //}








































        //public void Map()
        //{
        //    Console.Clear();
        //    Console.WriteLine("\n");
        //    Console.WriteLine("\t\t\t\t\t\t\t  MMMMMMMM               MMMMMMMM               AAA               PPPPPPPPPPPPPPPPP   ");
        //    Console.WriteLine("\t\t\t\t\t\t\t  M:::::::M             M:::::::M              A:::A              P::::::::::::::::P  ");
        //    Console.WriteLine("\t\t\t\t\t\t\t  M::::::::M           M::::::::M             A:::::A             P::::::PPPPPP:::::P ");
        //    Console.WriteLine("\t\t\t\t\t\t\t  M:::::::::M         M:::::::::M            A:::::::A            PP:::::P     P:::::P");
        //    Console.WriteLine("\t\t\t\t\t\t\t  M::::::::::M       M::::::::::M           A:::::::::A             P::::P     P:::::P");
        //    Console.WriteLine("\t\t\t\t\t\t\t  M:::::::::::M     M:::::::::::M          A:::::A:::::A            P::::P     P:::::P");
        //    Console.WriteLine("\t\t\t\t\t\t\t  M:::::::M::::M   M::::M:::::::M         A:::::A A:::::A           P::::PPPPPP:::::P ");
        //    Console.WriteLine("\t\t\t\t\t\t\t  M::::::M M::::M M::::M M::::::M        A:::::A   A:::::A          P:::::::::::::PP  ");
        //    Console.WriteLine("\t\t\t\t\t\t\t  M::::::M  M::::M::::M  M::::::M       A:::::A     A:::::A         P::::PPPPPPPPP    ");
        //    Console.WriteLine("\t\t\t\t\t\t\t  M::::::M   M:::::::M   M::::::M      A:::::AAAAAAAAA:::::A        P::::P            ");
        //    Console.WriteLine("\t\t\t\t\t\t\t  M::::::M    M:::::M    M::::::M     A:::::::::::::::::::::A       P::::P            ");
        //    Console.WriteLine("\t\t\t\t\t\t\t  M::::::M     MMMMM     M::::::M    A:::::AAAAAAAAAAAAA:::::A      P::::P            ");
        //    Console.WriteLine("\t\t\t\t\t\t\t  M::::::M               M::::::M   A:::::A             A:::::A   PP::::::PP          ");
        //    Console.WriteLine("\t\t\t\t\t\t\t  M::::::M               M::::::M  A:::::A               A:::::A  P::::::::P          ");
        //    Console.WriteLine("\t\t\t\t\t\t\t  M::::::M               M::::::M A:::::A                 A:::::A P::::::::P          ");
        //    Console.WriteLine("\t\t\t\t\t\t\t  MMMMMMMM               MMMMMMMMAAAAAAA                   AAAAAAAPPPPPPPPPP          ");

        //    const int SIZE_X = 100;
        //    const int SIZE_Y = 28;
        //    int location_X = 1;
        //    int location_Y = SIZE_Y / 2;

        //    int[,] map = new int[SIZE_Y, SIZE_X];

        //    for (int y = 0; y < SIZE_Y; y++)
        //    {
        //        for (int x = 0; x < SIZE_X; x++)
        //        {
        //            if (x == 0 || y == 0 || x == SIZE_X -1 || y == SIZE_Y -1)
        //            {
        //                map[y, x] = -1;
        //            }
        //            else if (x == location_X && y == location_Y)
        //            {
        //                map[y, x] = 1;
        //            }
        //            else
        //            {
        //                map[y, x] = 0;
        //            }
        //        }
        //    }

        //    Console.WriteLine("\n");

        //    for (int y = 0; y < SIZE_Y; y++)
        //    {
        //        for (int x = 0; x < SIZE_X; x++)
        //        {
        //            switch (map[y, x])
        //            {
        //                case -1:
        //                    Console.Write("■");
        //                    break;
        //                case 0:
        //                    Console.Write(".".PadRight(2));
        //                    break;
        //                case 1:
        //                    Console.Write("♀");
        //                    break;
        //                default:
        //                    break;
        //            }
        //        }
        //        Console.WriteLine();
        //    }

        //    Console.Write("방향키를 사용하여 이동하세요 : ");

        //    switch (Console.ReadLine())
        //    {
        //        case "w":
        //            location_Y = location_Y - 1;
        //            break;
        //        case "s":
        //            location_Y = location_Y + 1;
        //            break;
        //        case "a":
        //            location_X = location_X - 1;
        //            break;
        //        case "d":
        //            location_X = location_X + 1;
        //            break;
        //        default:
        //            ErrorMessage();
        //            Map();
        //            break;
        //    }

        //}   //  Map







    }

    }   //  class Program