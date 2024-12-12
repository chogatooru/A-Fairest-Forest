using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xboxTutr : MonoBehaviour {

    public GameObject xboximage;
	void Start () {
        if (Global.xboxin == false)
        {
            xboximage.SetActive(true);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
