using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverManager : MonoBehaviour
{
    //public PlayerHealth playerHealth;
    public float interval;

    Animator anim;


    void Awake()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (interval > 0)
        {
            interval -= Time.deltaTime;
        }
        else
        {
            anim.SetTrigger("GameOver");
        }
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(0);
    }
}
