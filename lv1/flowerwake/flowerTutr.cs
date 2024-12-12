using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flowerTutr : MonoBehaviour {


	// Use this for initialization
    void OnTriggerEnter(Collider coll)
    {
        if (coll.tag == "Player")
        {
            Global.flowercoll = true;
            GameObject.Find("flowerTutr").GetComponent<onetimeplay>().enabled = true;
            Debug.Log("in");
        }
    }
    void OnTriggerExit(Collider coll)
    {
        if (coll.tag == "Player")
        {
            Global.flowercoll = false;
            GameObject.Find("flowerTutr").GetComponent<onetimeplay>().enabled = false;
            Debug.Log("exit");
        }
    }
}