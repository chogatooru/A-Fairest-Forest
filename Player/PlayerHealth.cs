using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 100;
    public int currentHealth;
    public Slider healthSlider;
    public Image damageImage;
    public AudioClip deathClip;
    public float flashSpeed = 5f;
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);

    private Image image;


    Animator anim;
    AudioSource playerAudio;
    PlayerMovement playerMovement;
    PlayerShooting playerShooting;
    PlayerShootingLv3 PlayerShootingLv3;
    PlayerMovmentLv3 PlayerMovmentLv3;
    bool isDead;
    bool damaged;

    GameObject minimap;

    void Awake()
    {
        anim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
        playerMovement = GetComponent <PlayerMovement> ();
        playerShooting = GetComponentInChildren <PlayerShooting> ();

        PlayerMovmentLv3 = GetComponent<PlayerMovmentLv3>();
        PlayerShootingLv3 = GetComponentInChildren<PlayerShootingLv3>();
        currentHealth = startingHealth;

        minimap = GameObject.Find("Mask");

        image = GetComponent<Image>();
    }


    void Update()
    {
        if (damaged)
        {
            damageImage.color = flashColour;
        }
        else
        {
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }
        damaged = false;
    }


    public void TakeDamage(int amount)
    {
        damaged = true;

        currentHealth -= amount;

        healthSlider.value = currentHealth;


        playerAudio.Play();

        if (currentHealth <= 0 && !isDead)
        {
            Death();
        }
    }


    void Death()
    {
        isDead = true;

        playerShooting.DisableEffects ();

        anim.SetTrigger("Die");

        playerAudio.clip = deathClip;
        playerAudio.Play();

        playerMovement.enabled = false;
        playerShooting.enabled = false;
        PlayerMovmentLv3.enabled = false;
        PlayerShootingLv3.enabled = false;
        minimap.SetActive(false);
    }


    public void RestartLevel()
    {
        SceneManager.LoadScene(0);
    }
}