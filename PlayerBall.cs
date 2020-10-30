using System;


namespace Assets.MyScripts
{
    public sealed class PlayerBall : Player
    {

        private void FixedUpdate() // чтобы использовать PlayerBall, нужно добавлять поле Speed, иначе поле не меняется при баффе\дебаффе
        {
            Move();
        }
    }
}
