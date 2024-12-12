using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xboxx : MonoBehaviour {

    public Canvas MainCanvas;
    public Canvas OptionsCanvas;
    void Update()
    {

        if (Input.GetButtonDown("BACKction"))
        {
            Application.Quit();
            Global.xboxin = false;
        }

        if (Input.GetButtonDown("STARTction"))
        {
            Global.flowercoll = false;
            Global.dialoguecoll = false;
            Global.checkforend = 0;
            Global.flower = 0;
            Application.LoadLevel(1);
            Global.xboxin = false;
        }
        if (Input.GetButtonDown("Yction"))
        {
            OptionsCanvas.enabled = true;
            MainCanvas.enabled = false;
            Global.xboxin = false;
        }

        if (Input.GetButtonDown("Bction"))
        {
            OptionsCanvas.enabled = false;
            MainCanvas.enabled = true;
            Global.xboxin = false;
        }

        if (Input.GetButtonDown("Action"))
        {
            Global.flowercoll = false;
            Global.dialoguecoll = false;
            Global.checkforend = 0;
            Global.flower = 0;
            Application.LoadLevel(1);
            Global.xboxin = false;
        }
    }


}
