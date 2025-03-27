using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectsPlayer : MonoBehaviour
{
    public AudioSource src;
    public AudioSource src2;
    public AudioSource src3;
    public AudioClip sfx1, sfx2, sfx3, sfx4, sfx5, sfx6;
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
        src.clip = sfx4;
        src.Play();
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
