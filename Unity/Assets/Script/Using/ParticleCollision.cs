using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCollision : MonoBehaviour
{
    public int waterAmount;

    private void Start()
    {
        waterAmount = 0;
    }


    private void OnParticleCollision(GameObject other)
    {     
        waterAmount++;   
    }

}
