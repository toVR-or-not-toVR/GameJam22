using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomButton : MonoBehaviour
{

    [SerializeField] float timeToDestroy = 0.2f;
    // Start is called before the first frame update

    public void DestroyButton()
    {
        Destroy(gameObject, timeToDestroy);
    }
}
