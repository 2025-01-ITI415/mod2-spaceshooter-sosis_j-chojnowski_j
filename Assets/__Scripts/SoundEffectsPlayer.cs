using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectsPlayer : MonoBehaviour
{
    public AudioSource src;
    public AudioSource src2;
    public AudioSource src3;
    public AudioSource src4;
    public AudioSource PUObject;
    public AudioSource streakObject;

    public AudioClip sfx1, sfx2, sfx3, sfx4, sfx5, sfx6, rarePU, rarePUwords, fiveKS, tenKS, fifteenKS;
    public void enemyDeath()
    {
        src.clip = sfx1;
        src.Play();
    }
    public void moreShield()
    {
        src.clip = sfx2;
        src.Play();
    }
    public void shieldBrake()
    {
        src.clip = sfx3;
        src.Play();
    }
    public void powerUp()
    {
        PUObject.clip = sfx4;
        PUObject.Play();
    }
    public void backgroundMusic()
    {
        src2.clip = sfx5;
        src2.Play();
    }
    public void shootSound()
    {
        src3.clip = sfx6;
        src3.Play();
    }
    public void rareItem()
    {
        src.clip = rarePU;
        src.Play();
        PUObject.clip = rarePUwords;
        PUObject.Play();
    }
    public void fiveKillStreak()
    {
        streakObject.clip = fiveKS;
        streakObject.Play();
    }
    public void tenKillStreak()
    {
        streakObject.clip = tenKS;
        streakObject.Play();
    }
    public void fifteenKillStreak()
    {
        streakObject.clip = fifteenKS;
        streakObject.Play();
    }
    // Start is called before the first frame update
    void Start()
    {
        backgroundMusic();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
