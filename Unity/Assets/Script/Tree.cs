using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Tree : MonoBehaviour
{

    private DOTweenAnimation doTweeen;
    // Start is called before the first frame update
    void Start()
    {
        doTweeen = GetComponent<DOTweenAnimation>();
        
    }

   
 

    public void Playtree()
    {
        doTweeen.DOPlay();
    }

    public void StopPlay()
    {
        doTweeen.DOKill();
    }
}
