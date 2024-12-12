using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fdsfds : MonoBehaviour {


    void Update()
    {
        /* if (Input.GetAxis("RightVertical") > 0) { Debug.Log("+1"); }//dowm
         if (Input.GetAxis("RightVertical") == 0) { Debug.Log("0"); }
         if (Input.GetAxis("RightVertical") < 0) { Debug.Log("-1"); }//up

         if (Input.GetAxis("RightHorizontal") < 0) { Debug.Log("-2"); }//left
         if (Input.GetAxis("RightHorizontal") > 0) { Debug.Log("+2"); }//right

         if (Input.GetAxis("PadVertical") < 0) { Debug.Log("-3"); }//down
         if (Input.GetAxis("PadVertical") > 0) { Debug.Log("+3"); }//up */

        //获取摇杆偏移量
        float joyPositionX = Input.GetAxis("RightHorizontal");
        float joyPositionY = Input.GetAxis("RightVertical");

    }

}
