using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartWake : MonoBehaviour {

    public GameObject Heart;
    void OnTriggerEnter(Collider coll)
    {
        if (coll.tag == "Player")
        {
            Global.flowercoll = true;
            Heart.GetComponent<HeartManger>().enabled = true;
            Debug.Log("in");
        }
    }
    void OnTriggerExit(Collider coll)
    {
        if (coll.tag == "Player")
        {
            Global.flowercoll = false;
            Heart.GetComponent<HeartManger>().enabled = false;
            Debug.Log("exit");
        }
    }
}
