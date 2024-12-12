using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class Timer : MonoBehaviour
{
    public float timer = 3;
    public GameObject t;
    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            t.GetComponent<Text>().text = timer.ToString("00");
        }
    }
}