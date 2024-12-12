using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xboxback : MonoBehaviour {

    void Update()
    {
        if (Input.GetButtonDown("BACKction"))
        {
            Application.LoadLevel(9);
        }
    }
}
