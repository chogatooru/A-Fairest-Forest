using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour {

    public GameObject aarrow;

    void OnTriggerEnter(Collider coll)
    {
        if (coll.tag == "Player")
        {
            aarrow.SetActive(false);
            Global.dialoguecoll = true;
            //GameObject.Find("Zombunny (1)").GetComponent<EnemyMovement>().enabled = true;
            Debug.Log("in");
        }
    }
    void OnTriggerExit(Collider coll)
    {
        if (coll.tag == "Player")
        {
            aarrow.SetActive(true);
            Global.dialoguecoll = false;
            //GameObject.Find("Zombunny (1)").GetComponent<EnemyMovement>().enabled = true;
            Debug.Log("exit");
        }
    }
}
