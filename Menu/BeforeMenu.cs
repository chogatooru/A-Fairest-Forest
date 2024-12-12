using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeforeMenu : MonoBehaviour {

	// Use this for initialization

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Destroy(gameObject);
        }

        if (Input.GetButtonDown("Action"))
        {
            Application.LoadLevel(9);
            Global.xboxin = false;
        }
    }

    
}
