using System.Runtime.CompilerServices;

namespace ConsoleGame
{
    internal class Program
    {
        static void Main()
        {
            // 초기 설정
            GameManager.Initialize();

            SceneManager._sceneType = Scene.Title;

            while (true)
            {
                switch (SceneManager._sceneType)
                {
                    case Scene.Title:
                        SceneManager.Title();
                        break;
                    case Scene.Town:
                        SceneManager.Town();
                        break;
                    case Scene.RaceTrack:
                        SceneManager.RaceScene();
                        break;
                    default:
                        GameManager.ExitWithError($"잘못된 Scene타입입니다. {SceneManager._sceneType}");
                        return;
                }
            }
            //if (userInput != null)
            //{
            //    switch (userInput)
            //    {
            //        case "1":
            //            SceneManager.Town();
            //            break;
            //        case "2":
            //            RenderManager.RenderGameExit();
            //            Environment.Exit(2);
            //            break;
            //        default:
            //            GameManager.ExitWithError("잘못된 입력입니다. 1 혹은 2만 눌러주세요.");
            //            return;
            //    }
            //}

            

        }
    }
}