using System;

namespace MyNamespace
{
	class MyClass
	{
		static void Main(string[] args)
		{
			/**
			 * 지회 찾기
			 * 10 X 10 보드에 지뢰를 숨김 (n% 확률로 지회 매설)
			 * debug, mode 에서 지뢰가 아닌 곳은 .(닷), 지뢰인 곳은 #(샵)으로 표현
			 * play mode 에서 확인 되지 않은 곳은 전부 □(스퀘어)로 표현
			 * 첫 턴에 지뢰를 밟으면 해당 칸에 지뢰를 지워 줌
			 */


			Random randomMine = new Random();
			const int MINE_PERCETAGE = 30;
			const int BOARD_SIZE_X = 10;
			const int BOARD_SIZE_Y = 10;

			bool isDebugMode = false;
			bool isGameOver = false;
			bool isplayerWin = false;
			int playerTurnCnt = 0;

			/*
			 * 10 X 10 보드에 지뢰 초기화 한다
			 * 
			 * gameBoard 상태
			 * 지뢰 : MINE_PERCENTAGE 미안의 값
			 * 빈 칸 : MINE_PERCENTAGE 이상의 값
			 * 
			 * playBoard 상태
			 * -2 : 지뢰 있음
			 * -1 : 초기값
			 * n : 주변 9타일 이내에 지뢰 수 (0일 경우 ■표기, 양수일 경우 정수 표기)
			 * 
			 * mineCntBoard 상태
			 * -1 : 지뢰 있음
			 * n : 주변 9타일 이내에 지뢰 수
			 */

			int[,] gameBoard = new int[BOARD_SIZE_Y, BOARD_SIZE_X];
			int[,] playBoard = new int[BOARD_SIZE_Y, BOARD_SIZE_X];
			int[,] mineCntMap = new int[BOARD_SIZE_Y, BOARD_SIZE_X];

			for (int y = 0; y < BOARD_SIZE_Y; y++)
			{
				for (int x = 0; x < BOARD_SIZE_X; x++)
				{
					gameBoard[y, x] = randomMine.Next(1, 100 + 1);
					playBoard[y, x] = 1;

					if (gameBoard[y, x] < MINE_PERCETAGE)
					{
						mineCntMap[y, x] = -1;
							// if : 지뢰가 셋업된 경우
					}
					else
					{
						mineCntMap[y, x] = 0;
							//	else : 지뢰가 없는 경우
					}
				}
			}
			//	게임 시작
			while (isGameOver == false)
			{
				//	{현재 보드의 상태를 플레이 시점으로 보여준다}
				for (int y = 0; y < BOARD_SIZE_Y; y++)
				{
					for (int x = 0; x < BOARD_SIZE_X; x++)
					{
						switch (playBoard[y, x])
						{
							case -2:
								Console.Write("X".PadRight(3, ' ' ));
								break;
							case -1:
								Console.Write("□".PadRight(2, ' '));
								break;
							case 0:
								Console.Write("{0}.".PadRight(5, ' '), playBoard[y, x]);
								break;
						}
					}
					Console.WriteLine();
				}
				Console.WriteLine();

				int playerX = 0;
				int playerY = 0;
				bool isLocationvalid = false;

				while (isLocationvalid == false)
				{
					Console.Write("[플레이어] x 좌표 입력: ");

					int.TryParse(Console.ReadLine(), out playerX);

					Console.Write("[플레이어] y 좌표 입력: ");

					int.TryParse(Console.ReadLine(), out playerY);

					isLocationvalid =
						(0 <= playerX && playerX < BOARD_SIZE_X) &&
						(0 <= playerY && playerY < BOARD_SIZE_Y);

					if (isLocationvalid == false)
					{
						Console.WriteLine("{0} {1}", "[System] 해당 좌표는 유효하지 않습니다.");
						continue;
					}

					isLocationvalid = isLocationvalid && playBoard[playerY, playerX].Equals(-1);

					if (isLocationvalid == false)
					{
						Console.WriteLine("{0} {1}", "[System] 해당 좌표는 이미 오픈되었습니다.", "다른 좌표를 입력하세요");
						continue;
					}
                    playerTurnCnt++;

					if (playerTurnCnt.Equals(1))
					{
						gameBoard[playerY, playerX] = MINE_PERCETAGE + 1;
						mineCntMap[playerY, playerX] = 0;
						playBoard[playerY, playerX] = -1;

						for (int y = 0; y < BOARD_SIZE_Y; y++)
						{
							for (int x = 0; x < BOARD_SIZE_X; x++)
							{
								if (mineCntMap[y, x].Equals(-1) == false)
								{
									continue;

									bool isSearchTilevalid = false;

									for (int searchY = y; searchY <= y + 1; searchY++)
									{
										for (int searchX = x; searchX <= x + 1; searchX++)
										{
											isSearchTilevalid =
												(0 <= searchX && searchX < BOARD_SIZE_X) &&
												(0 <= searchY && searchY < BOARD_SIZE_Y);
											if (isSearchTilevalid == false)
											{
												continue;
											}

											if (mineCntMap[searchY, searchX].Equals(-1))
											{
												continue;
											}
										}
									}
								}
							}
						}
                        if (gameBoard[playerY, playerX] < MINE_PERCETAGE)
                        {
                            isGameOver = true;
                            isplayerWin = false;
                            playBoard[playerY, playerX] = -2;
                        }
                        else
                        {
                            bool isSearchTilevalid = false;

                            for (int searchY = playerY - 1; searchY <= playerY + 1; searchY++)
                            {
                                for (int searchX = playerX - 1; searchX <= playerX; searchX++)
                                {
                                    isSearchTilevalid =
                                        (0 <= searchX && searchX < BOARD_SIZE_X) &&
                                        (0 <= searchY && searchY < BOARD_SIZE_Y);
                                    if (isSearchTilevalid == false)
                                    {
                                        continue;
                                    }
                                    if (mineCntMap[searchY, searchX].Equals(-1))
                                    {
                                        playBoard[searchY, searchX] = -2;
                                    }
                                    else
                                    {
                                        playBoard[searchY, searchX] = mineCntMap[searchY, searchX];
                                    }
                                }
                            }
                        }
                        int unknownTikeCnt = 0;

                        for (int y = 0; y < BOARD_SIZE_Y; y++)
                        {
                            if (0 < unknownTikeCnt)
                            {
                                break;
                            }

                            for (int x = 0; x < BOARD_SIZE_X; x++)
                            {
                                if (playBoard[y, x].Equals(-1) &&
                                    mineCntMap[y, x].Equals(-1) == false)
                                {
                                    unknownTikeCnt++;
                                }
                            }
                        }
                        if (unknownTikeCnt.Equals(0))
                        {
                            isGameOver = true;
                            isplayerWin = true;
                        }

                        if (isGameOver)
                        {
                            break;
                        }
                        if (isDebugMode)
                        {
                            Console.WriteLine();

                            for (int y = 0; y < BOARD_SIZE_Y; y++)
                            {
                                for (int x = 0; x < BOARD_SIZE_X; x++)
                                {
                                    Console.WriteLine("{0} ", mineCntMap[y, x]);
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine();

                            for (int y = 0; y < BOARD_SIZE_Y; y++)
                            {
                                for (int x = 0; x < BOARD_SIZE_X; x++)
                                {
                                    if (gameBoard[y, x] < MINE_PERCETAGE)
                                    {
                                        Console.WriteLine("# ");
                                    }
                                    else
                                    {
                                        Console.WriteLine(". ");
                                    }
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine();
                        }
                    }
                    Console.WriteLine();

                    for (int y = 0; y < BOARD_SIZE_Y; y++)
                    {
                        for (int x = 0; x < BOARD_SIZE_X; x++)
                        {
                            switch (playBoard[y, x])
                            {
                                case -2:
                                    Console.WriteLine("X".PadRight(3, ' '));
                                    break;
                                case -1:
                                    Console.WriteLine("□".PadRight(2, ' '));
                                    break;
                                case 0:
                                    Console.WriteLine("■".PadRight(2, ' '));
                                    break;
                                default:
                                    Console.WriteLine("{0}".PadRight(5, ' '), playBoard[y, x]);
                                    break;
                            }
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();

                    if (isplayerWin)
                    {
                        Console.WriteLine("[플레이어] 지뢰를 모두 찾고 승리했습니다.");
                    }
                    else
                    {
                        Console.WriteLine("[플레이어] 지뢰를 밟고 패배했습니다.");
                    }
                }
            }
		}
	}
}