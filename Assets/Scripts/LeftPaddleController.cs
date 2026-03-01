using UnityEngine;

public class LeftPaddleController : PaddleController
{
   protected override float GetMovemnetInput()
   {
       return Input.GetAxis("Player1Vertical");
   }

}
