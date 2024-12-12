using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullManger : MonoBehaviour {

    public AudioSource play;
    void OnMouseOver()
    {

        if (Global.flowercoll == true && Input.GetMouseButtonDown(1))
        {
            play.Play();
            shootnuv.shootnumber += 10;
            
            Global.flowercoll = false;
            Destroy(gameObject);

        }

    }

    void Update()
    {
        Debug.Log(Global.flowercoll);
        if (Global.flowercoll == true && Input.GetButtonDown("Bction"))
        {
            play.Play();
            shootnuv.shootnumber += 10;

            Global.flowercoll = false;
            Destroy(gameObject);

        }

    }
}
