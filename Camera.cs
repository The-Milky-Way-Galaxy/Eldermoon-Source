using Raylib_cs;
using System.Numerics;

namespace Eldermoon;

class Camera
{
    public Camera3D CoreCamera = new Camera3D();
    Vector3 CorePosition = new Vector3(0, 0, 100);
    Matrix4x4 Rotation = new Matrix4x4();

    public Camera()
    {
        CoreCamera.FovY = 45;
        CoreCamera.Target = new Vector3(0, 0, 0);
        CoreCamera.Up = new Vector3(0, 1, 0);
        CoreCamera.Projection = CameraProjection.Perspective;
    }
    public void Update()
    {
        Rotation = Matrix4x4.CreateFromYawPitchRoll(
        Mouse.XinRad, Mouse.YinRad, 0);

        CoreCamera.Position = Vector3.Transform(CorePosition, Rotation);
    }
}