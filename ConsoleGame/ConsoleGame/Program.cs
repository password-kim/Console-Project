using System.Runtime.CompilerServices;

namespace ConsoleGame
{
    internal class Program
    {
        static void Main()
        {
            // 초기 설정
            GameManager.Initialize();

            // 매니저 생성.
            RenderManager renderManager = new RenderManager();
            CollisionManager collisionManager = new CollisionManager();
            SceneManager sceneManager = new SceneManager();

            renderManager.RenderTitle();
            string userInput = Console.ReadLine();

            if (userInput != null)
            {
                switch (userInput)
                {
                    case "1":
                        sceneManager.Town();
                        break;
                    case "2":
                        renderManager.RenderGameExit();
                        Environment.Exit(2);
                        break;
                    default:
                        GameManager.ExitWithError("잘못된 입력입니다. 1 혹은 2만 눌러주세요.");
                        return;
                }
            }

            Player player = new Player();
            Wall[] walls = new Wall[Constants.WALL_COUNT];
            Npc[] npcs = new Npc[Constants.NPC_COUNT];
            Dialog[] dialogs = new Dialog[Constants.DIALOG_COUNT];
            
            string[] scene = sceneManager.LoadSene("Town");
            sceneManager.ParseScene(scene, out player, out walls, out npcs, out dialogs);

            while (true)
            {
                // ========= Render =============
                Console.Clear();

                // 플레이어 출력.
                renderManager.RenderObject(player.X, player.Y, ObjectSymbol.Player);

                // 벽 출력.
                for (int wallId = 0; wallId < Constants.WALL_COUNT; ++wallId)
                {
                    renderManager.RenderObject(walls[wallId].X, walls[wallId].Y, ObjectSymbol.Wall);
                }

                // 대화창 출력
                for (int dialogIdx = 0; dialogIdx < Constants.DIALOG_COUNT; ++dialogIdx)
                {
                    renderManager.RenderObject(dialogs[dialogIdx].X, dialogs[dialogIdx].Y, dialogs[dialogIdx].Shape);
                }

                // npc 출력.
                for (int npcId = 0; npcId < Constants.NPC_COUNT; ++npcId)
                {
                    renderManager.RenderObject(npcs[npcId].X, npcs[npcId].Y, ObjectSymbol.Npc);
                }




                // ========= Input ==============
                ConsoleKey key = Console.ReadKey().Key;

                // ========= Update =============

                player.MovePlayer(key);
                collisionManager.OnCollisionWithWall(player, walls);
                collisionManager.OnCollisionWithNpc(player, npcs);
                

            }

        }
    }
}