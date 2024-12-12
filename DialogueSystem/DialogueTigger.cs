using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTigger : MonoBehaviour
{
    public Dialogue dialogue;

    void Update()
    {
        if (Global.dialoguecoll == true && Input.GetButtonDown("Bction"))
        {


            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            Global.dialoguecoll = false;
            Destroy(this);
        }

    }

    void OnMouseOver()
    {
        if (Global.dialoguecoll == true && Input.GetMouseButtonDown(1))
        {

            
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            Global.dialoguecoll = false;
            Destroy(this);
        }

    }

    public void TriggerDialogue()
    {
        if (Global.dialoguecoll == true)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            Global.dialoguecoll = false;
        }
    }

}