using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class NewMouth : MonoBehaviour
{

    private DOTweenAnimation doTweeen;
    List<Tween> tweens;
    public int indexTween;
    // Start is called before the first frame update
    void Start()
    {
        indexTween = 0;
        doTweeen = GetComponent<DOTweenAnimation>();
        tweens = doTweeen.GetTweens();
    }

    // Update is called once per frame
 

    public void MouthAnimation(float timeToKill)
    {
        tweens[indexTween].Play();
        StartCoroutine(StopAfter(timeToKill));
    }


    IEnumerator StopAfter(float stopTime)
    {
        yield return new WaitForSeconds(stopTime);
        tweens[indexTween].Kill();
        indexTween++;
    }
}

