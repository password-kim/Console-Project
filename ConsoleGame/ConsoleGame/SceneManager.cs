using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class SceneManager
    {
        public string[] LoadSene(string scene)
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

        public void ParseScene(string[] scene, out Player player, out Wall[] walls, out Npc[] npcs, out Dialog[] dialogs)
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

        public void Town()
        {
            while (true)
            {

            }
        }

        public void GoTownScene()
        {

        }
        
        public void GoRaceScene()
        {

        }

    }
}
