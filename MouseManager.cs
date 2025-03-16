using Raylib_cs;
using System.Numerics;

namespace Eldermoon;

static class Mouse
{
    static int Monitor = Raylib.GetCurrentMonitor();
    static float XinDeg;
    static float YinDeg;

    public static float XinRad;
    public static float YinRad;
    
    public static void Update()
    {
        if(Raylib.GetMouseX() == 0)
        {
            Raylib.SetMousePosition(Raylib.GetMonitorWidth(Monitor) - 2, Raylib.GetMouseY());
        }

        if(Raylib.GetMouseX() == Raylib.GetMonitorWidth(Monitor)-1)
        {
            Raylib.SetMousePosition(1, Raylib.GetMouseY());
        }
        
        XinDeg = Raymath.Remap
        (
        Raylib.GetMouseX(), 
        0, Raylib.GetMonitorWidth(Monitor),
        0, 360
        );

        YinDeg = Raymath.Remap
        (
        Raylib.GetMouseY()-1, 
        0, Raylib.GetMonitorHeight(Monitor),
        0, 360
        );

        XinRad = Raymath.Remap
        (
        XinDeg, 
        0, 360,
        0, MathF.PI * 2
        );

        YinRad = Raymath.Remap
        (
        YinDeg + (Raylib.GetMonitorHeight(Monitor)/2), 
        0, 360,
        0, MathF.PI
        );
    }
}