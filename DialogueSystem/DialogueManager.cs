using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text dialogueText;
    public Text nameText;
    private Queue<string> sentences;
    public Animator animator;
    public Animator yesorno;
    public Animator player;
    bool countniue = false;

    void Start()
    {
        
        sentences = new Queue<string>();
        
    }

    public void StartDialogue(Dialogue dialogue)
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<lv1Movement>().enabled = false;
        player.SetBool("IsWalking", false);
        animator.SetBool("IsOpen", true);
        yesorno.SetBool("IsOpen", false);
        sentences.Clear();
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        countniue = true;
        DisplayNextSentence();


    }
    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    void Update()
    {


        if (Input.GetButtonDown("Fire1") && countniue == true)
        {
            string sentence = sentences.Dequeue();
            StopAllCoroutines();
            StartCoroutine(TypeSentence(sentence));

            if (sentences.Count == 0)
            {
                
                
                countniue = false;
                EndDialogue();
                return;
            }
        }

    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }


    void EndDialogue()
    {
       
        
        if (Global.checkforend == 0 )
        {
            animator.SetBool("IsOpen", false);
            yesorno.SetBool("IsOpen", true);
            GameObject.Find("YesOrNo").GetComponent<YesOrNo>().enabled = true;
            
            Global.dialoguecoll = true;
            Global.checkforend += 1;
            
        }
        else if (Global.checkforend == 1)
        {

            animator.SetBool("IsOpen", false);
            Application.LoadLevel(6);
            Global.checkforend += 1;
            Global.dialoguecoll = false;
        }

        else if (Global.checkforend == 2)
        {
            animator.SetBool("IsOpen", false);
            Application.LoadLevel(7);
            Global.checkforend += 1;
        }

        else if (Global.checkforend == 3)
        {
            animator.SetBool("IsOpen", false);
            Application.LoadLevel(8);
            Global.checkforend += 1;
        }



    }
}
