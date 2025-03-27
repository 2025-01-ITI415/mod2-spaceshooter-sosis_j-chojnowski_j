using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectsPlayer : MonoBehaviour
{
    public AudioSource src;
    public AudioClip sfx1, sfx2, sfx3;
    public void enemyDeath()
    {
        src.clip = sfx1;
        src.Play();
    }
    public void fireSound()
    {
        src.clip = sfx2;
        src.Play();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
