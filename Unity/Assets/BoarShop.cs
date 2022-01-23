using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class BoarShop : MonoBehaviour
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


    public void Animation()
    {
        Debug.Log("Board");
        tweens[1].Play();
        
    }




}
