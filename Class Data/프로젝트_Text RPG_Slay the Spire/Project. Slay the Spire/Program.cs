using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

namespace Project._Slay_the_Spire
{
    public class Program
    {
        string NAME;    //  클래스 이름
        int max_HP;     //  max_Health Point, 최대체력
        int HP;         //  Health Point, 체력
        int STR;        //  Strangth, 힘
        int DEX;        //  Dexterity, 민첩
        int WIS;        //  Wisdom, 지혜  
        int LUCK;       //  행운
        int GOLD;       //  골드
        int AP;         //  Attack Power, 공격력
        int DP;         //  Defence Power, 방어력
        bool isGameOver = false;
        int userInput;

        Random random = new Random();



        static void Main(string[] args)
        {
            Console.SetWindowSize(200, 50);     //  콘솔 화면 크기 지정하기

            Program program = new Program();
            program.MainMenu();
            program.MainMenuSelection();





        }   //  Main ()



        public void MainMenu()  //   메인화면 출력
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
        }   //  MainMenu

        public void MainMenuSelection() //  메인메뉴 선택 옵션
        {
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
                        ErrorMessage();
                        MainMenu();
                        break;
                }
            }
        }   //  MainMenuSelection

        public void ErrorMessage()  //  잘못된 입력을 받을 경우 출력하는 화면
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
        }

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
                        MainMenu();
                        MainMenuSelection();
                        isGameOver = true;
                        break;
                    default:
                        ErrorMessage();
                        GameInformation();
                        break;
                }
            }
        }   //  Information

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

        public void CharacterSelection()    //  캐릭터 선택 화면
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
                    NAME = "모험가";
                    max_HP = 80;
                    HP = max_HP;
                    STR = 3;
                    DEX = 3;
                    WIS = 3;
                    LUCK = 3;
                    GOLD = 100;
                    StartScreen();
                    break;
                case 2:
                    NAME = "기사";
                    max_HP = 100;
                    HP = max_HP;
                    STR = 5;
                    DEX = 5;
                    WIS = 1;
                    LUCK = 1;
                    GOLD = 100;
                    StartScreen();
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    ErrorMessage();
                    CharacterSelection();
                    break;
            }

        }   //  CharacterSelection

        public void StartScreen()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;     //  출력 색갈 설정
            Console.SetCursorPosition(70, 10);  //  출력 위치 설정

            string text = "탑에 들어서자 거대한 문 앞에 어쩌구 저쩌구 ~";

            for (int i = 0; i < text.Length; i++)   //  한글자씩 출력 + 출력 지연
            {
                Console.Write(text[i]);
                Thread.Sleep(80);
            }

            Console.ForegroundColor = ConsoleColor.White;   //  출력 색갈 설정

            Console.ReadLine();
            MyInformation();
            ActionChoice();
        }   //  StartScreen

        public void MyInformation()
        {
            Console.Clear();

            Console.WriteLine("=======================================================================================================================================================================================================");
            Console.WriteLine($"     직업 : {NAME}          ♥ : {max_HP} / {HP}                              STR : {STR}  DEX : {DEX}  WIS : {WIS}  LUCK : {LUCK}                                              GOLD : {GOLD}");
            Console.WriteLine("=======================================================================================================================================================================================================");
            Console.WriteLine("                                                                                       보유 아이템");
            Console.WriteLine("①\n");
            Console.WriteLine("②\n");
            Console.WriteLine("③\n");
            Console.WriteLine("=======================================================================================================================================================================================================");
        }   //  MyInformation

        public void ActionChoice()
        {
            Console.WriteLine("\n");
            Console.WriteLine("\t@@@@@@@@@@@@@@@@@@@@@@@~@@@@@@@@@@@@@@@@                                                                                          ");
            Console.WriteLine("\t@@@@@@@@@@@@@@@@@@ -;~,.,@~@@@@@@@@@@@@@                                                                                          ");
            Console.WriteLine("\t@@@@@@@@@@@@@@@@@@-. . ,,, @@@@@@@@@@@@@                                                                                          ");
            Console.WriteLine("\t@@@@@@@@@@@@@@@@@@~.  .-~. @@@@@@@@@@@@@                                                                                          ");
            Console.WriteLine("\t@@@@@@@@@@@@@@@@@@;~- ..,,.@@@@@@@@@@@@@                                                                                          ");
            Console.WriteLine("\t@@@@@@@@@@@@@@@@@-!:..,,~,.@@@@@@@@@@@@@                                                                                          ");
            Console.WriteLine("\t@@@@@@@@@@@@@@@  .;*: ,-:~.@@@@@@@@@@@@@                                                                                          ");
            Console.WriteLine("\t@@@@@@@@@@@@@ ..  .:!!.-~-@@@@@@@@@@@@@@                                                                                          ");
            Console.WriteLine("\t@@@@@@@@@@@.    .  .;;*;;,@@@@@@@@@@@@@@                                                                                          ");
            Console.WriteLine("\t@@@@@@@@@@@.  ....  ,:;:.,-@@@@@@@@@@@@@                                                                                          ");
            Console.WriteLine("\t@@@@@@@@@@.,:~ ...    -.,.~@@@@@@@@@@@@@                                                                                          ");
            Console.WriteLine("\t@@@@@@@@@@:--~;;.    . ,,-~@@@@@@@@@@@@@                                                                                          ");
            Console.WriteLine("\t@@@@@@@@@. .~:**:,  ...,,!;@@@@@@@@@@@@@                                                                                          ");
            Console.WriteLine("\t@@@@@@@@@  ,:@;*. ,....,,:*:@@@@@@@@@@@@                                                                                          ");
            Console.WriteLine("\t@@@@@@@@~ .-@@~! ,-,...,::~:@@@@@@@@@@@@                                                                                          ");
            Console.WriteLine("\t@@@@@@@@  ,@@@@. ,,-~..-;--. @@@@@@@@@@@                                                                                          ");
            Console.WriteLine("\t@@@@@@@  ,@@.~.  ,,---.!: ., .@@@@@@@@@@                                                                                          ");
            Console.WriteLine("\t@@@@@@  .-, .  .., -~-,..~ ,,  @@@@@@@@@                                                                                          ");
            Console.WriteLine("\t@@@@@@ .~,,   ...@@.. .. ,-@..  @@@@@@@@                                                                                          ");
            Console.WriteLine("\t@@@@@@ ,,,   ..--@@@@@,...,-@@, .@@@@@@@                                                                                          ");
            Console.WriteLine("\t@@@@@@@@@... .,.@@@@@@-,...,.@@... @@@@@                                                                                          ");
            Console.WriteLine("\t@@@@@@@@@    .,.@@@@@@.,..... @ ,.,@@@@@                                                                                          ");
            Console.WriteLine("\t@@@@@@@ .   .,@@@@@@@@::-,.... .:~@@@@@@                                                                                          ");
            Console.WriteLine("\t@@@@@@@.   ,:@@@@@@@@@@@@@~~,..-..@@@@@@                                                                                          ");
            Console.WriteLine("\t@@@@@@@- .~~@@@@@@@@@@@@@@@@ ...~@@@@@@@                                                                                          ");
            Console.WriteLine("\t@@@@@@@~. -@@@@@@@@@@@@@@@@@ ...-@@@@@@@                                                                                          ");
            Console.WriteLine("\t@@@@@@@~. @@@@@@@@@@@@@@@@@@@-...@@@@@@@                                                                                          ");
            Console.WriteLine("\t@@@@@@@~.-;@@@@@@@@@@@@@@@@@@@~-. @@@@@@                                                                                          ");
            Console.WriteLine("\t@@@@@@@@.~@@@@@@@@@@@@@@@@@@@@@~,~@@@@@@                                                                                          ");
            Console.WriteLine("\t@@@@@@@@ ~@@@@@@@@@@@@@@@@@@@@@@~-@@@@@@                                                                                          ");
            Console.WriteLine("\t@@@@@@@.,,@@@@@@@@@@@@@@@@@@@@@@.,,@@@@@                                                                                          ");
            Console.WriteLine("\t@@@@@@..,.:@@@@@@@@@@@@@@@@@@@@@$,.. @@@                                                                                          ");
            Console.WriteLine("\t@@@@@@=:$@=@@@@@@@@@@@@@@@@@@@@@#::#!@@@                                                                                          ");
            Console.WriteLine("\t@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@                                                                                          ");

            Console.ReadLine();

            Event();
        }

        public void Event()
        {
            int randomEvent = random.Next(1, 2);

            switch (randomEvent)
            {
                case 1:
                    Event_NormalMonster();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    break;
            }
        }

        public void Event_NormalMonster()   //  이벤트_일반 몬스터
        {
            int randomNormalMonster = random.Next(1, 2);

            switch (randomNormalMonster)
            {
                case 1:
                    NAME = "광신자(Cultist)";
                    max_HP= 40;
                    HP = max_HP;
                    AP = 6;
                    DP = 5;
                    STR = 0;
                    DEX = 0;
                    BattleScreen();
                    NormalMonster_Cultist();
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
        }

        public void Event_EliteMonster()    //  이벤트_엘리트 몬스터
        {

        }

        public void Event_BossMonster()     //  이벤트_보스 몬스터
        {

        }

        public void Event_MysteryMerchant() //  이벤트_수수께끼 상인
        {

        }

        public void Event_Rest()    //  이벤트_휴식
        {

        }

        public void BattleScreen()
        {
            Console.Clear();

            MyInformation();
        }



        public void NormalMonster_Cultist()
        {
            Console.WriteLine("\t$==#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("\t=***=#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("\t##@#*$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("\t@@@@**#@@@@@@@@@@@@@@@@@@@@@@@@@@@**=@@@");
            Console.WriteLine("\t*@@@=*#@@@@@@@@@@@@@@@@@@@@@@@@@@@##;=@@");
            Console.WriteLine("\t=$@@$*#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#:#@");
            Console.WriteLine("\t@=#@=*#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@!!#");
            Console.WriteLine("\t@==#;*#@@@@@=#@@@@@@@@@@@@@@@@@@@*@@@**#");
            Console.WriteLine("\t@@*=!#@@@@@$!!#@@@@@@@@@@@@@@@@@@*#@@;*#");
            Console.WriteLine("\t@@=*$#@@@=!;!~..*@@@@@@@@@@@@@@@@=#@@;$@");
            Console.WriteLine("\t@@@*#@@@@*!!.   .#@@@@@@@@@@@@@@==#@;*#@");
            Console.WriteLine("\t@@@==*@@*!!. .   ;#@@@@@@@@@$$#$!=$;;#@@");
            Console.WriteLine("\t@@@@!;#**!; .!. .,::#@@@@@@=~:~:::;;*#@@");
            Console.WriteLine("\t@@@@!:;;!!,......,-*=#@@@;=;~~~~~::!=#@@");
            Console.WriteLine("\t@@@@*!!::~..;;,~--~;!!;!;:~~~~~~:::!##@@");
            Console.WriteLine("\t@@@@===!;..~;~~;:;:;;::~~:~~:~~~:::~:##@");
            Console.WriteLine("\t@@@@**!;!-!;~~:::;;;:~---~~~~~-;:~::::*#");
            Console.WriteLine("\t@@@@!!!!;!;:!;:::::;:---~~~~~~~;~~~~~~;;");
            Console.WriteLine("\t@@@@=;;!;!!!#*;::;:;;~~:*:~~~~:;~~~~~::!");
            Console.WriteLine("\t@@@@*;!!*=####;::;:;;;:;#*;:~:~~:~::::;$");
            Console.WriteLine("\t@@@@*=#=#$#@@;;;:;;:::;!#@!=;:::::::~::*");
            Console.WriteLine("\t@@@@@#@##@@@@!;;:;;;:::!#@@#$#***:~::*=#");
            Console.WriteLine("\t@@@@@@@@@@@@@;;;:::;;::;#@@@@@@#@;!::!$#");
            Console.WriteLine("\t@@@@@@@@@@@@@*;;:;;;;;;:$@@@@@@@@@#=###@");
            Console.WriteLine("\t@@@@@@@@@@@@;;;::;;;;;;;=#@@@@@@@@@@@#@@");
            Console.WriteLine("\t@@@@@@@@@@@@*;;::;;::;:;;#@@@@@@@@@@@@@@");
            Console.WriteLine("\t@@@@@@@@@@@@=;:;:::::;::*#@@@@@@@@@@@@@@");
            Console.WriteLine("\t@@@@@@@@@@@*;;::;::;:;;:#@@@@@@@@@@@@@@@");
            Console.WriteLine("\t@@@@@@@@@@@!:::;;;;;::::;#@@@@@@@@@@@@@@");
            Console.WriteLine("\t@@@@@@@@@@!:;;:;:;::::::;=@@@@@=@@@@@@@@");
            Console.WriteLine("\t@@@@@@@@@@==;;;:;:;;::;;;!#;!:;;#@@@@@@@");
            Console.WriteLine("\t@@@@@@@@@@@=;::!;;!*;;;;:;;;;;=##@@@@@@@");
            Console.WriteLine("\t@@@@@@@@@@@@#=~*!=#*~!*=;;;;*=#@@@@@@@@@");
            Console.WriteLine("\t@@@@@@@@@@@@@@~*###=-;###==###@@@@@@@@@@");
            Console.WriteLine("\t@@@@@@@@@@@@@@~*#@@@--#@@@#@@@@@@@@@@@@@");
            Console.WriteLine("\t@@@@@@@@@@@@@@:*#@@@=~~:#@@@@@@@@@@@@@@@");
            Console.WriteLine("\t@@@@@@@@@@@@@::*#@@=:~#;;@@@@@@@@@@@@@@@");
      
        }






























































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









    }   //  class Program

}