using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{

    [SerializeField] Tree doTween;
    // Start is called before the first frame update

    private void Start()
    {
        doTween = FindObjectOfType<Tree>();
    }

    private void Update()
    {
        if (Time.time >= 1f)
        {
            doTween.Playtree();
        }
    }

}
