using UnityEngine;

public class RightPaddleController : PaddleController
{
    protected override float GetMovemnetInput()
    {
       return Input.GetAxis("Player2Vertical");
   }
}
