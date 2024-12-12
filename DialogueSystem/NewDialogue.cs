using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewDialogue : MonoBehaviour {

    public GameObject clickme;

    void OnTriggerEnter(Collider coll)
    {
        if (coll.tag == "Player")
        {
            clickme.SetActive(true);  
            Global.dialoguecoll = true;
            //GameObject.Find("Zombunny (1)").GetComponent<EnemyMovement>().enabled = true;
            Debug.Log("in");
        }
    }
    void OnTriggerExit(Collider coll)
    {
        if (coll.tag == "Player")
        {
            clickme.SetActive(false);
            Global.dialoguecoll = false;
            //GameObject.Find("Zombunny (1)").GetComponent<EnemyMovement>().enabled = true;
            Debug.Log("exit");
        }
    }
}
