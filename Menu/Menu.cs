using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Menu : MonoBehaviour
{

    public Canvas MainCanvas;
    public Canvas OptionsCanvas;

    void Awake()
    {
        //OptionsCanvas.enabled = false;
    }

    public void AboutOn()
    {
        OptionsCanvas.enabled = true;
        MainCanvas.enabled = false;
    }
    public void AboutOff()
    {
        OptionsCanvas.enabled = false;
        MainCanvas.enabled = true;
    }

    public void Quit()
    {
        Application.Quit();
    }

    // Use this for initialization

    public void LockOn()
    {
        Application.LoadLevel(0);
    }
}
