using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullwake : MonoBehaviour {

    public GameObject Bull;
    void OnTriggerEnter(Collider coll)
    {
        if (coll.tag == "Player")
        {
            Global.flowercoll = true;
            Bull.GetComponent<BullManger>().enabled = true;
            Debug.Log("in");
        }
    }
    void OnTriggerExit(Collider coll)
    {
        if (coll.tag == "Player")
        {
            Global.flowercoll = false;
            Bull.GetComponent<BullManger>().enabled = false;
            Debug.Log("exit");
        }
    }
}
