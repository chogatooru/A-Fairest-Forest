using UnityEngine;
using System.Collections;

public class Zoom : MonoBehaviour
{

    void Start()
    {

    }


    void Update()
    {
        //Zoom out  
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (Camera.main.fieldOfView <= 75)
                Camera.main.fieldOfView += 1;
            if (Camera.main.orthographicSize <= 50)
                Camera.main.orthographicSize += 0.1F;
        }
        //Zoom in  
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if (Camera.main.fieldOfView > 35)
                Camera.main.fieldOfView -= 1;
            if (Camera.main.orthographicSize >= 1)
                Camera.main.orthographicSize -= 0.1F;
        }

        //Zoom out  
        if (Input.GetAxis("PadVertical") < 0)
        {
            if (Camera.main.fieldOfView <= 75)
                Camera.main.fieldOfView += 1;
            if (Camera.main.orthographicSize <= 50)
                Camera.main.orthographicSize += 0.1F;
        }
        //Zoom in  
        if (Input.GetAxis("PadVertical") > 0)
        {
            if (Camera.main.fieldOfView > 35)
                Camera.main.fieldOfView -= 1;
            if (Camera.main.orthographicSize >= 1)
                Camera.main.orthographicSize -= 0.1F;
        }
    }
}  
