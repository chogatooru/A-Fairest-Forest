using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour {

    float timer;
    GameObject Fadeimage;

	void Start () {
        timer = 0;
       Fadeimage = GameObject.Find("FadeIn");
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer >= 2)
        {
            Destroy(Fadeimage);
        }
	}
}
