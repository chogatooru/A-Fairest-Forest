using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutr : MonoBehaviour {

	// Use this for initialization
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Application.LoadLevel(2);
        }
        else if (Input.GetButtonDown("Action"))
        {
            Application.LoadLevel(2);
        }
    }

}
