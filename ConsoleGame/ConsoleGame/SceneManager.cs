using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    enum Scene
    {
        None,
        Title,
        Town,
        RaceTrack,
        Exit
    }

    internal class SceneManager
    {
        public static Scene _sceneType;

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
                        case ObjectSymbol.Npc:
                            npcs[npcCounts] = new Npc { X = x, Y = y };
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
                            GameManager.ExitWithError("오브젝트 심볼이 잘못되었습니다.");
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
                        case 'R':
                            dialogs[dialogCounts] = new Dialog { X = x, Y = y, Shape = 'R' };
                            dialogCounts++;
                            break;
                        case 'a':
                            dialogs[dialogCounts] = new Dialog { X = x, Y = y, Shape = 'a' };
                            dialogCounts++;
                            break;
                        case 'k':
                            dialogs[dialogCounts] = new Dialog { X = x, Y = y, Shape = 'k' };
                            dialogCounts++;
                            break;
                        case '1':
                            dialogs[dialogCounts] = new Dialog { X = x, Y = y, Shape = '1' };
                            dialogCounts++;
                            break;
                        case '2':
                            dialogs[dialogCounts] = new Dialog { X = x, Y = y, Shape = '2' };
                            dialogCounts++;
                            break;
                        case '3':
                            dialogs[dialogCounts] = new Dialog { X = x, Y = y, Shape = '3' };
                            dialogCounts++;
                            break;
                        case '4':
                            dialogs[dialogCounts] = new Dialog { X = x, Y = y, Shape = '4' };
                            dialogCounts++;
                            break;
                        case '5':
                            dialogs[dialogCounts] = new Dialog { X = x, Y = y, Shape = '5' };
                            dialogCounts++;
                            break;
                        case '6':
                            dialogs[dialogCounts] = new Dialog { X = x, Y = y, Shape = '6' };
                            dialogCounts++;
                            break;
                        case 's':
                            dialogs[dialogCounts] = new Dialog { X = x, Y = y, Shape = 's' };
                            dialogCounts++;
                            break;
                        case 't':
                            dialogs[dialogCounts] = new Dialog { X = x, Y = y, Shape = 't' };
                            dialogCounts++;
                            break;
                        case 'n':
                            dialogs[dialogCounts] = new Dialog { X = x, Y = y, Shape = 'n' };
                            dialogCounts++;
                            break;
                        case 'd':
                            dialogs[dialogCounts] = new Dialog { X = x, Y = y, Shape = 'd' };
                            dialogCounts++;
                            break;
                        case 'r':
                            dialogs[dialogCounts] = new Dialog { X = x, Y = y, Shape = 'r' };
                            dialogCounts++;
                            break;
                        case 'h':
                            dialogs[dialogCounts] = new Dialog { X = x, Y = y, Shape = 'h' };
                            dialogCounts++;
                            break;
                        case ':':
                            dialogs[dialogCounts] = new Dialog { X = x, Y = y, Shape = ':' };
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
            Player player = new Player();
            Wall[] walls = new Wall[Constants.WALL_COUNT];
            Npc[] npcs = new Npc[Constants.NPC_COUNT];
            Dialog[] dialogs = new Dialog[Constants.DIALOG_COUNT];

            string[] scene = LoadSene("Town");
            ParseTownScene(scene, out player, out walls, out npcs, out dialogs);

            while (true)
            {
                // ========= Render =============
                Console.Clear();

                // 플레이어 상태 체크
                RenderManager.ShowState(player);

                // 플레이어 출력.
                RenderManager.RenderObject(player.X, player.Y, ObjectSymbol.Player);

                // 벽 출력.
                for (int wallId = 0; wallId < Constants.WALL_COUNT; ++wallId)
                {
                    RenderManager.RenderObject(walls[wallId].X, walls[wallId].Y, ObjectSymbol.Wall);
                }

                // 대화창 출력
                for (int dialogIdx = 0; dialogIdx < Constants.DIALOG_COUNT; ++dialogIdx)
                {
                    RenderManager.RenderObject(dialogs[dialogIdx].X, dialogs[dialogIdx].Y, dialogs[dialogIdx].Shape);
                }

                // npc 출력.
                for (int npcId = 0; npcId < Constants.NPC_COUNT; ++npcId)
                {
                    RenderManager.RenderObject(npcs[npcId].X, npcs[npcId].Y, ObjectSymbol.Npc);
                }

                // ========= Input ==============
                ConsoleKey key = Console.ReadKey().Key;

                // ========= Update =============

                player.MovePlayer(key);
                CollisionManager.OnCollisionWithWall(player, walls);
                CollisionManager.OnCollisionWithNpc(player, npcs);
                player.TalkToNpc(key, npcs);

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
            string[] scene = LoadSene("RaceTrack");
            ParseRaceScene(scene, out walls, out dialogs, out horses);

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
                    RenderManager.RenderObject(horses[horseId].X, horses[horseId].Y, horses[horseId].Shape);
                }


                // ========= Input ==============
                ConsoleKey key = Console.ReadKey().Key;
                //if (Console.KeyAvailable)
                //{
                //    key = Console.ReadKey().Key;
                //}


                // ========= Update =============
                for (int horseId = 0; horseId < Constants.HORSE_COUNT; ++horseId)
                {
                    horses[horseId].X += (int)(rand.NextDouble()* 3);
                    if (horses[horseId].X >= 80)
                    {
                        horses[horseId].X = 80;
                    }
                }

                if (key == ConsoleKey.R)
                {
                    for (int horseId = 0; horseId < Constants.HORSE_COUNT; ++horseId)
                    {
                        horses[horseId].X = 0;
                    }
                }

                //Thread.Sleep(250);
            }


        }

    }
}
