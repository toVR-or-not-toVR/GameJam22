using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteArrowCollision : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject arrow;
    [SerializeField] GameObject hologram_affect;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Grabber")
        {
            Destroy(arrow);
            hologram_affect.SetActive(true);
        }
       
    }
}
