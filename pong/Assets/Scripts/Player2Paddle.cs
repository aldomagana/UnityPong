using UnityEngine;

public class Player2Paddle : PaddleController
{
    protected override float GetInputAxis()
    {
        return Input.GetAxis("player2Vertical");
    }
}
