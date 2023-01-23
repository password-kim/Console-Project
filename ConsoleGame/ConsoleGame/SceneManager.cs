namespace ConsoleGame
{
    enum Scene
    {
        None,
        Title,
        Town,
        RaceTrack,
        Shop,
        Exit
    }

    internal class SceneManager
    {
        public static Scene _sceneType;
        public static Scene _prevSceneType;

        public static string[] LoadSene(string scene)
        {
            // 1. 경로를 구성한다.
            string sceneFilePath = Path.Combine("Assets", "MapTile", $"{scene}.txt");

            // 2. 파일이 존재하는지 확인한다.
            if (false == File.Exists(sceneFilePath))
            {
                GameManager.ExitWithError($"Scene파일이 없습니다. Scene파일 이름 : {scene}");
            }

            // 3. 파일의 내용을 불러온다.
            return File.ReadAllLines(sceneFilePath);
        }

        public static void ParseTownScene(string[] scene, out Player player, out Wall[] walls, out Npc[] npcs, out Dialog[] dialogs)
        {
            string[] sceneMetaData = scene[scene.Length - 1].Split(" ");
            player = null;
            walls = new Wall[int.Parse(sceneMetaData[0])];
            int wallCounts = 0;
            dialogs = new Dialog[int.Parse(sceneMetaData[1])];
            int dialogCounts = 0;
            npcs = new Npc[int.Parse(sceneMetaData[2])];
            int npcCounts = 0;

            for (int y = 0; y < scene.Length - 1; ++y)
            {
                for (int x = 0; x < scene[y].Length; ++x)
                {
                    switch (scene[y][x])
                    {
                        case ObjectSymbol.Player:
                            player = new Player { X = x, Y = y };
                            break;
                        case ObjectSymbol.Wall:
                            walls[wallCounts] = new Wall { X = x, Y = y };
                            wallCounts++;
                            break;
                        case ObjectSymbol.RaceNpc:
                            npcs[npcCounts] = new Npc { X = x, Y = y, Type = NpcType.RaceNpc };
                            npcCounts++;
                            break;
                        case ObjectSymbol.ShopNpc:
                            npcs[npcCounts] = new Npc { X = x, Y = y, Type = NpcType.ShopNpc };
                            npcCounts++;
                            break;
                        case '┌':
                            dialogs[dialogCounts] = new Dialog { X = x, Y = y, Shape = '┌' };
                            dialogCounts++;
                            break;
                        case '┐':
                            dialogs[dialogCounts] = new Dialog { X = x, Y = y, Shape = '┐' };
                            dialogCounts++;
                            break;
                        case '└':
                            dialogs[dialogCounts] = new Dialog { X = x, Y = y, Shape = '└' };
                            dialogCounts++;
                            break;
                        case '┘':
                            dialogs[dialogCounts] = new Dialog { X = x, Y = y, Shape = '┘' };
                            dialogCounts++;
                            break;
                        case '━':
                            dialogs[dialogCounts] = new Dialog { X = x, Y = y, Shape = '━' };
                            dialogCounts++;
                            break;
                        case '┃':
                            dialogs[dialogCounts] = new Dialog { X = x, Y = y, Shape = '┃' };
                            dialogCounts++;
                            break;
                        case ' ':
                            break;
                        default:
                            GameManager.ExitWithError($"오브젝트 심볼이 잘못되었습니다. {scene[y][x]}");
                            return;
                    }
                }
            }
        }

        public static void ParseRaceScene(string[] scene, out Wall[] walls, out Dialog[] dialogs, out Horse[] horses)
        {
            string[] sceneMetaData = scene[scene.Length - 1].Split(" ");
            walls = new Wall[int.Parse(sceneMetaData[0])];
            int wallCounts = 0;
            dialogs = new Dialog[int.Parse(sceneMetaData[1])];
            int dialogCounts = 0;
            horses = new Horse[int.Parse(sceneMetaData[2])];
            int horseCounts = 0;

            for (int y = 0; y < scene.Length - 1; ++y)
            {
                for (int x = 0; x < scene[y].Length; ++x)
                {
                    switch (scene[y][x])
                    {
                        case ObjectSymbol.Wall:
                            walls[wallCounts] = new Wall { X = x, Y = y };
                            wallCounts++;
                            break;
                        case '┌':
                            dialogs[dialogCounts] = new Dialog { X = x, Y = y, Shape = '┌' };
                            dialogCounts++;
                            break;
                        case '┐':
                            dialogs[dialogCounts] = new Dialog { X = x, Y = y, Shape = '┐' };
                            dialogCounts++;
                            break;
                        case '└':
                            dialogs[dialogCounts] = new Dialog { X = x, Y = y, Shape = '└' };
                            dialogCounts++;
                            break;
                        case '┘':
                            dialogs[dialogCounts] = new Dialog { X = x, Y = y, Shape = '┘' };
                            dialogCounts++;
                            break;
                        case '─':
                            dialogs[dialogCounts] = new Dialog { X = x, Y = y, Shape = '─' };
                            dialogCounts++;
                            break;
                        case '┃':
                            dialogs[dialogCounts] = new Dialog { X = x, Y = y, Shape = '┃' };
                            dialogCounts++;
                            break;
                        case 'A':
                            horses[horseCounts] = new Horse { X = x, Y = y, Shape = 'A' };
                            horseCounts++;
                            break;
                        case 'B':
                            horses[horseCounts] = new Horse { X = x, Y = y, Shape = 'B' };
                            horseCounts++;
                            break;
                        case 'C':
                            horses[horseCounts] = new Horse { X = x, Y = y, Shape = 'C' };
                            horseCounts++;
                            break;
                        case 'D':
                            horses[horseCounts] = new Horse { X = x, Y = y, Shape = 'D' };
                            horseCounts++;
                            break;
                        case 'E':
                            horses[horseCounts] = new Horse { X = x, Y = y, Shape = 'E' };
                            horseCounts++;
                            break;
                        case 'F':
                            horses[horseCounts] = new Horse { X = x, Y = y, Shape = 'F' };
                            horseCounts++;
                            break;
                        case 'G':
                            horses[horseCounts] = new Horse { X = x, Y = y, Shape = 'G' };
                            horseCounts++;
                            break;
                        case 'H':
                            horses[horseCounts] = new Horse { X = x, Y = y, Shape = 'H' };
                            horseCounts++;
                            break;
                        case 'I':
                            horses[horseCounts] = new Horse { X = x, Y = y, Shape = 'I' };
                            horseCounts++;
                            break;
                        case 'J':
                            horses[horseCounts] = new Horse { X = x, Y = y, Shape = 'J' };
                            horseCounts++;
                            break;
                        case ' ':
                            break;
                        default:
                            GameManager.ExitWithError($"오브젝트 심볼이 잘못되었습니다. {scene[y][x]}");
                            return;
                    }
                }
            }
        }

        public static void ParseShopScene(string[] scene, out Player player, out Wall[] walls, out Npc[] npcs, out Dialog[] dialogs)
        {
            string[] sceneMetaData = scene[scene.Length - 1].Split(" ");
            player = null;
            walls = new Wall[int.Parse(sceneMetaData[0])];
            int wallCounts = 0;
            dialogs = new Dialog[int.Parse(sceneMetaData[1])];
            int dialogCounts = 0;
            npcs = new Npc[int.Parse(sceneMetaData[2])];
            int npcCounts = 0;

            for (int y = 0; y < scene.Length - 1; ++y)
            {
                for (int x = 0; x < scene[y].Length; ++x)
                {
                    switch (scene[y][x])
                    {
                        case ObjectSymbol.Player:
                            player = new Player { X = x, Y = y };
                            break;
                        case ObjectSymbol.Wall:
                            walls[wallCounts] = new Wall { X = x, Y = y };
                            wallCounts++;
                            break;
                        case ObjectSymbol.ShopNpc:
                            npcs[npcCounts] = new Npc { X = x, Y = y, Type = NpcType.ShopNpc };
                            npcCounts++;
                            break;
                        case '┌':
                            dialogs[dialogCounts] = new Dialog { X = x, Y = y, Shape = '┌' };
                            dialogCounts++;
                            break;
                        case '┐':
                            dialogs[dialogCounts] = new Dialog { X = x, Y = y, Shape = '┐' };
                            dialogCounts++;
                            break;
                        case '└':
                            dialogs[dialogCounts] = new Dialog { X = x, Y = y, Shape = '└' };
                            dialogCounts++;
                            break;
                        case '┘':
                            dialogs[dialogCounts] = new Dialog { X = x, Y = y, Shape = '┘' };
                            dialogCounts++;
                            break;
                        case '━':
                            dialogs[dialogCounts] = new Dialog { X = x, Y = y, Shape = '━' };
                            dialogCounts++;
                            break;
                        case '┃':
                            dialogs[dialogCounts] = new Dialog { X = x, Y = y, Shape = '┃' };
                            dialogCounts++;
                            break;
                        case ' ':
                            break;
                        default:
                            GameManager.ExitWithError($"오브젝트 심볼이 잘못되었습니다. {scene[y][x]}");
                            return;
                    }
                }
            }
        }

        public static void Title()
        {
            Console.SetWindowSize(150, 50);

            while (true)
            {
                RenderManager.RenderTitle();
                string playerInput = Console.ReadLine();
                if (playerInput == "1")
                {
                    _sceneType = Scene.Town;
                    break;
                }

            }
        }

        public static void Town()
        {
            Console.SetWindowSize(100, 40);

            Player player = new Player();
            Wall[] walls = new Wall[Constants.TOWN_WALL_COUNT];
            Npc[] npcs = new Npc[Constants.TOWN_NPC_COUNT];
            Dialog[] dialogs = new Dialog[Constants.TOWN_DIALOG_COUNT];

            string[] scene = LoadSene("Town");
            ParseTownScene(scene, out player, out walls, out npcs, out dialogs);

            while (true)
            {
                // ========= Render =============
                Console.Clear();
                
                // 플레이어 상태 체크
                RenderManager.ShowState(player);

                Console.SetCursorPosition(32, 9);
                Console.Write("경마장");

                Console.SetCursorPosition(14, 1);
                Console.Write("상점");

                // 플레이어 출력.
                if (SceneManager._prevSceneType == Scene.Shop)
                {
                    player.X = 19;
                    player.Y = 1;
                    RenderManager.RenderObject(player.X, player.Y, ObjectSymbol.Player);

                }
                else
                {
                    RenderManager.RenderObject(player.X, player.Y, ObjectSymbol.Player);

                }

                SceneManager._prevSceneType = Scene.None;

                // 벽 출력.
                for (int wallId = 0; wallId < Constants.TOWN_WALL_COUNT; ++wallId)
                {
                    RenderManager.RenderObject(walls[wallId].X, walls[wallId].Y, ObjectSymbol.Wall);
                }

                // 대화창 출력
                for (int dialogIdx = 0; dialogIdx < Constants.TOWN_DIALOG_COUNT; ++dialogIdx)
                {
                    RenderManager.RenderObject(dialogs[dialogIdx].X, dialogs[dialogIdx].Y, dialogs[dialogIdx].Shape);
                }

                // npc 출력.
                for (int npcId = 0; npcId < Constants.TOWN_NPC_COUNT; ++npcId)
                {
                    if (npcs[npcId].Type == NpcType.RaceNpc)
                    {
                        RenderManager.RenderObject(npcs[npcId].X, npcs[npcId].Y, ObjectSymbol.RaceNpc);
                    }
                    if (npcs[npcId].Type == NpcType.ShopNpc)
                    {
                        RenderManager.RenderObject(npcs[npcId].X, npcs[npcId].Y, ObjectSymbol.ShopNpc);
                    }
                }


                // ========= Input ==============
                ConsoleKey key = Console.ReadKey().Key;

                // ========= Update =============

                player.MovePlayer(key);
                CollisionManager.OnCollisionWithWallInTown(player, walls);
                CollisionManager.OnCollisionWithNpcInTown(player, npcs);
                player.TalkToNpc(key, npcs);

                if ((player.X == 18 || player.X == 19) && player.Y == 0)
                {
                    SceneManager._sceneType = Scene.Shop;
                    SceneManager._prevSceneType = Scene.Town;
                    break;
                }

                if (SceneManager._sceneType != Scene.Town)
                {
                    break;
                }

            }
        }

        public static void RaceScene()
        {
            Random rand = new Random();
            Wall[] walls = new Wall[Constants.RACE_WALL_COUNT];
            Dialog[] dialogs = new Dialog[Constants.RACE_DIALOG_COUNT];
            Horse[] horses = new Horse[Constants.HORSE_COUNT];
            int[] horsesSpeed = new int[Constants.HORSE_COUNT];
            string[] scene = LoadSene("RaceTrack");
            ParseRaceScene(scene, out walls, out dialogs, out horses);
            int[] rank = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            int[] price = { 1000, 900, 800, 700, 600, 300, 200, 100, 50, 0 };
            string playerChoice = "1";
            bool isChoice = false;
            bool isRaceEnd = false;

            while (true)
            {
                // ========= Render =============
                Console.Clear();
                
                // 벽 출력.
                for (int wallId = 0; wallId < Constants.RACE_WALL_COUNT; ++wallId)
                {
                    RenderManager.RenderObject(walls[wallId].X, walls[wallId].Y, ObjectSymbol.Wall);
                }

                // Dialog 출력.
                for (int dialogIdx = 0; dialogIdx < Constants.RACE_DIALOG_COUNT; ++dialogIdx)
                {
                    RenderManager.RenderObject(dialogs[dialogIdx].X, dialogs[dialogIdx].Y, dialogs[dialogIdx].Shape);
                }

                // 말 출력.
                for (int horseId = 0; horseId < Constants.HORSE_COUNT; ++horseId)
                {
                    if (horseId == int.Parse(playerChoice) - 1)
                    {
                        ConsoleColor prev = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;
                        RenderManager.RenderObject(horses[horseId].X, horses[horseId].Y, horses[horseId].Shape);
                        Console.ForegroundColor = prev;
                    }
                    else
                    {
                        RenderManager.RenderObject(horses[horseId].X, horses[horseId].Y, horses[horseId].Shape);
                    }
                }

                RenderManager.ShowRank(rank, playerChoice, horsesSpeed);
                //RenderManager.ShowRankTest(rank);

                // ========= Input ==============
                ConsoleKey key = ConsoleKey.NoName;
                if (Console.KeyAvailable)
                {
                    key = Console.ReadKey().Key;
                }

                if (false == isChoice)
                {
                    Console.SetCursorPosition(25, 15);
                    Console.Write("몇번말에 거시겠습니까?");
                    playerChoice = Console.ReadLine();
                    isChoice = true;
                }


                // ========= Update =============

                for (int horseId = 0; horseId < Constants.HORSE_COUNT; ++horseId)
                {
                    horsesSpeed[horseId] = (int)(1 + RandomManager.GetInctance.NextDouble() * 3);

                }


                for (int horseId = 0; horseId < Constants.HORSE_COUNT; ++horseId)
                {
                    horses[horseId].X += horsesSpeed[horseId];
                    if (horses[horseId].X >= 95)
                    {
                        horses[horseId].X = 95;
                    }
                }

                for (int horseId = 0; horseId < Constants.HORSE_COUNT; ++horseId)
                {
                    if (horses[horseId].X == 95)
                    {
                        horsesSpeed[horseId] = 0;
                    }
                }


                for (int horseId = 0; horseId < Constants.HORSE_COUNT; ++horseId)
                {
                    if (horses[horseId].X == 95)
                    {
                        continue;
                    }
                    rank[horseId] = 1;
                    for (int horseId2 = 0; horseId2 < Constants.HORSE_COUNT; ++horseId2)
                    {
                        if (horseId == horseId2)
                        {
                            continue;
                        }
                        else
                        {
                            if (horses[horseId].X < horses[horseId2].X)
                            {
                                rank[horseId]++;
                            }
                        }
                    }
                }

                for (int horseId = 0; horseId < Constants.HORSE_COUNT; ++horseId)
                {
                    if (horses[horseId].X == 95)
                    {
                        isRaceEnd = true;
                    }
                    else
                    {
                        isRaceEnd = false;
                        break;
                    }
                }

                if (isRaceEnd)
                {
                    Console.SetCursorPosition(25, 15);
                    Console.Write($"당신은 {price[rank[int.Parse(playerChoice) - 1] - 1]}원을 받았습니다.");
                }


                // Temp
                // 말들의 위치를 처음으로 되돌린다.
                if (key == ConsoleKey.R)
                {
                    for (int horseId = 0; horseId < Constants.HORSE_COUNT; ++horseId)
                    {
                        horses[horseId].X = 0;
                    }
                }

                if (key == ConsoleKey.C)
                {
                    RenderManager.ShowBackDialog();
                    Console.SetCursorPosition(53, 14);
                    string input = Console.ReadLine();

                    if (input == "y" || input == "yes")
                    {
                        Player.Money += price[rank[int.Parse(playerChoice) - 1] - 1];
                        SceneManager._sceneType = Scene.Town;
                        SceneManager._prevSceneType = Scene.RaceTrack;
                    }
                }


                if (SceneManager._sceneType != Scene.RaceTrack)
                {
                    break;
                }

                Thread.Sleep(200);
            }


        }

        public static void ShopScene()
        {
            Console.SetWindowSize(100, 40);
            Player player = new Player();
            Npc[] npcs = new Npc[Constants.SHOP_NPC_COUNT];
            Wall[] walls = new Wall[Constants.SHOP_WALL_COUNT];
            Dialog[] dialogs = new Dialog[Constants.SHOP_DIALOG_COUNT];

            string[] scene = LoadSene("Shop");
            ParseShopScene(scene, out player, out walls, out npcs, out dialogs);

            while (true)
            {
                // ========= Render =============
                Console.Clear();

                // 플레이어 상태 체크
                RenderManager.ShowState(player);


                // 플레이어 출력.
                RenderManager.RenderObject(player.X, player.Y, ObjectSymbol.Player);

                // 벽 출력.
                for (int wallId = 0; wallId < Constants.SHOP_WALL_COUNT; ++wallId)
                {
                    RenderManager.RenderObject(walls[wallId].X, walls[wallId].Y, ObjectSymbol.Wall);
                }

                // 대화창 출력
                for (int dialogIdx = 0; dialogIdx < Constants.SHOP_DIALOG_COUNT; ++dialogIdx)
                {
                    RenderManager.RenderObject(dialogs[dialogIdx].X, dialogs[dialogIdx].Y, dialogs[dialogIdx].Shape);
                }

                // npc 출력.
                for (int npcId = 0; npcId < Constants.SHOP_NPC_COUNT; ++npcId)
                {
                    if (npcs[npcId].Type == NpcType.RaceNpc)
                    {
                        RenderManager.RenderObject(npcs[npcId].X, npcs[npcId].Y, ObjectSymbol.RaceNpc);
                    }
                    if (npcs[npcId].Type == NpcType.ShopNpc)
                    {
                        RenderManager.RenderObject(npcs[npcId].X, npcs[npcId].Y, ObjectSymbol.ShopNpc);
                    }
                }


                // ========= Input ==============
                ConsoleKey key = Console.ReadKey().Key;

                // ========= Update =============

                player.MovePlayer(key);
                CollisionManager.OnCollisionWithWallInShop(player, walls);
                CollisionManager.OnCollisionWithNpcInShop(player, npcs);
                player.TalkToNpc(key, npcs);

                if ((player.X == 13 || player.X == 14) && player.Y == 14)
                {
                    SceneManager._sceneType = Scene.Town;
                    SceneManager._prevSceneType = Scene.Shop;
                    break;
                }

                if (SceneManager._sceneType != Scene.Shop)
                {
                    break;
                }
            }


        }

    }
}
