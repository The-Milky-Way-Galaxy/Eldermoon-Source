using Raylib_cs;
using System.Numerics;

namespace Eldermoon;

class Particle
{
    public Vector3 Position = new Vector3(0, 0, 0);
    Matrix4x4 Direction = new Matrix4x4();
    float Gravity = 0;
    float GravityIncrement;
    float DecayTime;
    float Lifespan;

    public Particle(Vector3 Position, Matrix4x4 Direction, 
     float GravityIncrement, float Lifespan)
    {
        this.Position = Position;
        this.Direction = Direction;
        this.GravityIncrement = GravityIncrement*100;
        this.Lifespan = Lifespan;
    }

    public void Update()
    {
        Position = Vector3.Transform(Position, Direction);
        Position.Y -= Gravity;
        Gravity += GravityIncrement*Raylib.GetFrameTime();
        DecayTime += Raylib.GetFrameTime();
    }
}