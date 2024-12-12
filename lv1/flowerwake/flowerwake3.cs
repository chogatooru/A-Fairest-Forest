using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flowerwake3 : MonoBehaviour
{

	// Use this for initialization
    void OnTriggerEnter(Collider coll)
    {
        if (coll.tag == "Player")
        {
            Global.flowercoll = true;
            GameObject.Find("flower03 (3)").GetComponent<Flower>().enabled = true;
            Debug.Log("in");
        }
    }
    void OnTriggerExit(Collider coll)
    {
        if (coll.tag == "Player")
        {
            Global.flowercoll = false;
            GameObject.Find("flower03 (3)").GetComponent<Flower>().enabled = false;
            Debug.Log("exit");
        }
    }
}
