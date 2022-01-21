using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteWateringHologram : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject arrow;
    [SerializeField] GameObject hologram_affect;

    [SerializeField] WaterLevel waterLevel; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Grabber")
        {
            Destroy(arrow);
            hologram_affect.SetActive(true);
        }
    }

    private void Awale()
    {
        waterLevel = GetComponent<WaterLevel>();
    }

    private void FixedUpdate()
    {
        if (waterLevel.currentLevel >= 1)
        {
            hologram_affect.SetActive(false);
        } 
    }




}
