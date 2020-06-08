using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship.Scene
{
    class SceneController
    {
        List<IScene> Scenes = new List<IScene>();

        public SceneController()
        {
            MainMenu mainMenu = new MainMenu();
            Scenes.Add(mainMenu);

            Options options = new Options();
            Scenes.Add(options);

            NewGame newGame = new NewGame();
            Scenes.Add(newGame);

            GameboardScene gameboard = new GameboardScene();
            Scenes.Add(gameboard);
        }

        public IScene GetScene(SceneEnum SelectedScene)
        {
            return Scenes[(int)SelectedScene];
        }

        public void PrintScene(SceneEnum SelectedScene)
        {
            Scenes[(int)SelectedScene].Print();
        }
    }
}
