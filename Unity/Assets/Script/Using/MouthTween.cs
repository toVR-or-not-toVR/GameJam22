using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MouthTween : MonoBehaviour
{
    // Start is called before the first frame update
    private DOTweenAnimation doTweeen;

    [SerializeField] float killAfterTime;

    // Start is called before the first frame update
    void Start()
    {
        doTweeen = GetComponent<DOTweenAnimation>();
    }


    public void Playtree(float tomeToKill)
    {
        doTweeen.DOPlay();
        StartCoroutine(StopAfter(tomeToKill));
    }


    IEnumerator StopAfter(float stopTime)
    {
        yield return new WaitForSeconds(stopTime);
        doTweeen.DOKill();
    }
}
