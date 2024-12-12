using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shootnuv : MonoBehaviour {
    public static int shootnumber;
    
    Text text;
	void Start () {
        shootnumber = 20;
        text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        text.text = "x" + shootnumber;
	}
}
