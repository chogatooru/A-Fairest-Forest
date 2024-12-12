using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flowerfakewake1 : MonoBehaviour
{

	// Use this for initialization
    void OnTriggerEnter(Collider coll)
    {
        if (coll.tag == "Player")
        {
            Global.flowercoll = true;
            GameObject.Find("flowerfake (1)").GetComponent<onetimeplay>().enabled = true;
            Debug.Log("in");
        }
    }
    void OnTriggerExit(Collider coll)
    {
        if (coll.tag == "Player")
        {
            Global.flowercoll = false;
            GameObject.Find("flowerfake (1)").GetComponent<onetimeplay>().enabled = false;
            Debug.Log("exit");
        }
    }
}
