using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverLv1 : MonoBehaviour {

    public Animator yesorno;
    Animator anim;
    GameObject minimap;
	// Use this for initialization
    void Awake(){
        minimap = GameObject.Find("Mask");
    }
    public void GameOverTigger()
    {
        yesorno.SetBool("IsOpen", false);
        anim = GetComponent<Animator>();
        anim.SetTrigger("GameOver");
        minimap.SetActive(false);
    }
}
