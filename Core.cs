using Raylib_cs;
using System.Numerics;

namespace Eldermoon;

class Core
{
    static int Monitor = Raylib.GetCurrentMonitor();
    static Camera SceneCamera = new Camera();
    public static void Main()
    {       
        Raylib.InitWindow(Raylib.GetMonitorWidth(Monitor), Raylib.GetMonitorHeight(Monitor), "Eldermoon");
        Raylib.ToggleFullscreen();
        Raylib.HideCursor();
        Raylib.SetExitKey(KeyboardKey.Null);

        while (!Raylib.WindowShouldClose())
        {
            //Update loop
            Mouse.Update();
            SceneCamera.Update();
            
            //Draw loop
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.White);

            Raylib.BeginMode3D(SceneCamera.CoreCamera);
            Raylib.DrawCubeV
            (
            new Vector3(0, 5, 0), 
            new Vector3(10, 10, 10), 
            Color.Blue
            );

            Raylib.DrawCubeV
            (
            new Vector3(0, -0.5f, 0), 
            new Vector3(100, 1, 100), 
            Color.Green
            );

            Raylib.EndMode3D();
            Raylib.DrawText(Raylib.GetMouseX().ToString(), 12, 12, 20, Color.Black);

            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}
