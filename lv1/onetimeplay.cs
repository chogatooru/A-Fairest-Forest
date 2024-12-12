using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onetimeplay : MonoBehaviour {

    public AudioSource click;
    void OnMouseOver()
    {
        if (Global.flowercoll == true && Input.GetMouseButtonDown(1))
        {
            click.Play();
            Destroy(gameObject);
        }
    }
    	void Update () {
        if (Global.flowercoll == true&&Input.GetButtonDown("Bction"))
        {
            click.Play();
            Destroy(gameObject);
        }
	}
	

            

}
