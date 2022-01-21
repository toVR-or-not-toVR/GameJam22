using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatSAberBot : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    public bool playTime;

    public AudioClip audioToPlayStart;
    public AudioClip audioToPlaycongrats;
    NewMouth newMouth;

    SceneLoaderCustom sceneLoaderCustom;

    private void Start()
    {
        newMouth = FindObjectOfType<NewMouth>();
        animator = GetComponent<Animator>();
        sceneLoaderCustom = GetComponent<SceneLoaderCustom>();

    }


    public void PlaySpekingAnimation()
    {
        AudioSource.PlayClipAtPoint(audioToPlayStart, transform.position);
        StartCoroutine(MoveFromPlayer());
       newMouth.MouthAnimation(audioToPlayStart.length);
        

    }

    public void PlayCongrats()
    {
        AudioSource.PlayClipAtPoint(audioToPlaycongrats, transform.position);
        newMouth.MouthAnimation(audioToPlaycongrats.length);
        //sceneLoaderCustom.LoadChapter2Scene(audioToPlaycongrats.length + 1, "ThreeScene");
    }

    IEnumerator MoveFromPlayer()
    {
        yield return new WaitForSeconds(audioToPlayStart.length-3f);
        animator.SetTrigger("FromPlayer");
        
    }
}
