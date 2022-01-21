using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotSpeaking : MonoBehaviour
{

   
    public AudioClip audioToPlay;
    public AudioClip doneSound;
    NewMouth newMouth;
    private void Start()
    {
        newMouth = FindObjectOfType<NewMouth>();
     }



    public void PlaySpekingAnimation()
    {
        AudioSource.PlayClipAtPoint(audioToPlay, transform.position, 1f);
        newMouth.MouthAnimation(audioToPlay.length);                
    }

    public void PlayCongersSpeatch()
    {
        AudioSource.PlayClipAtPoint(doneSound, transform.position, 1f);
        newMouth.MouthAnimation(doneSound.length - 1f);
    }

}
