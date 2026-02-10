using UnityEngine;

public class Player1Paddle : PaddleController
{
    protected override float GetInputAxis()
    {
        return Input.GetAxis("player1Vertical");
    }
}
