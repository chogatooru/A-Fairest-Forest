using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global
{
    public static int flower;
    public static int checkforend=0;
    public static int enemycheck1;
    public static bool xboxin = true;
    public static bool flowercoll = false ;
    public static bool dialoguecoll = false;

}


public class Flower : MonoBehaviour
{

    public AudioSource play;
   
    void OnMouseOver()
    {

        if (Global.flowercoll == true && Input.GetMouseButtonDown(1))
        {
            play.Play();
            Global.flower += 1;
            Destroy(gameObject);
            Global.flowercoll = false;



        }
    }


    void Update()
    {

        if (Global.flowercoll == true && Input.GetButtonDown("Bction"))
        {
            play.Play();
            Global.flower += 1;
            Destroy(gameObject);
            Global.flowercoll = false;
            
        }



    }
}
