using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotChapterThree : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    public bool playTime;

    public AudioClip startSpeach;
    public AudioClip makeGlucoseSound;
    public AudioClip sunSpeach;
    public AudioClip prevCongrestsSound;
    public AudioClip finalCound;



    [SerializeField] MouthTween doTween;
    [SerializeField] NewMouth newMouth;


    private void Start()
    {
        doTween = FindObjectOfType<MouthTween>();
        animator = GetComponent<Animator>();
        newMouth = FindObjectOfType<NewMouth>();

    }
      

    public void PlayStartSpeach()
    {
        AudioSource.PlayClipAtPoint(startSpeach, transform.position);
        //doTween.Playtree(startSpeach.length);
        newMouth.MouthAnimation(startSpeach.length);
    }

    public void PlayGlucoseSpeach()
    {
        AudioSource.PlayClipAtPoint(makeGlucoseSound, transform.position);
        newMouth.MouthAnimation(makeGlucoseSound.length);
    }

    public void PlaySunSpeach()
    {
        AudioSource.PlayClipAtPoint(sunSpeach, transform.position);
        newMouth.MouthAnimation(sunSpeach.length);
    }

    public void PrevCongretsSpeach()
    {
        AudioSource.PlayClipAtPoint(prevCongrestsSound, transform.position);
        newMouth.MouthAnimation(prevCongrestsSound.length);
    }


    public void FinalSpeach()
    {
        AudioSource.PlayClipAtPoint(finalCound, transform.position);
        newMouth.MouthAnimation(finalCound.length);
    }

}
