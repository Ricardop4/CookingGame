using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] AudioClip eatingSound;
    [SerializeField] AudioClip pickupSound;
    
    public void PlayEatSound()
    {
        AudioSource.PlayClipAtPoint(eatingSound, Camera.main.transform.position);
    }
    public void PlayPickUpSound()
    {
        AudioSource.PlayClipAtPoint(pickupSound, Camera.main.transform.position);
    }
}
