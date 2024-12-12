using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeFlower : MonoBehaviour {

    public AudioSource fakeplay;
    void OnMouseDown()
    {
        if (Global.flowercoll == true)
        {
            fakeplay.Play();
           
            Destroy(gameObject);
            Global.flowercoll = false;


        }

    }

}
