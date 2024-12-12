using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class letterlv : MonoBehaviour {

    void Awake()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<lv1Movement>().enabled = false;
    }
        void Update()
    {

            if(Input.GetButtonDown("Fire1")){
                Application.LoadLevel(11);
            }
    }

}
