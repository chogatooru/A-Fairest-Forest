using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class letterB : MonoBehaviour {

    public GameObject LETTER;


    void Update()
    {
        if (Global.dialoguecoll == true && Input.GetButtonDown("Bction"))
        {


            LETTER.SetActive(true);
            Global.dialoguecoll = false;
            Destroy(this);
        }

    }

    void OnMouseOver()
    {
        if (Global.dialoguecoll == true && Input.GetMouseButtonDown(1))
        {

            LETTER.SetActive(true);

            Global.dialoguecoll = false;
            Destroy(this);
        }

    }
}
