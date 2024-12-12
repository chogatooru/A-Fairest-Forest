using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutr2 : MonoBehaviour {

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Application.LoadLevel(4);
        }
    }
}
