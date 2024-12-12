using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YesOrNo : MonoBehaviour {

    public Dialogue dialogue;
    Animator yesorno;
    public Animator anim;
    public Animator Countion;
	void Update () {
		if (Input.GetButtonDown("Action")){
            if (Global.dialoguecoll == true)
            {
                FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
                Global.dialoguecoll = false;
                GameObject.Find("YesOrNo").GetComponent<YesOrNo>().enabled = false;
            }
        }
        if (Input.GetButtonDown("Bction")){
            yesorno = GetComponent<Animator>();
            yesorno.SetBool("IsOpen", false);
            Countion.SetBool("IsOpen", false);
            anim.SetTrigger("GameOver");
            GameObject.Find("DialogueManager").GetComponent<DialogueManager>().enabled = false;
            GameObject.Find("YesOrNo").GetComponent<YesOrNo>().enabled = false;
        }
	}
}
