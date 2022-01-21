using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Destroing objects that collision with collider
public class DestroyObject : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "WrongGas" || other.gameObject.tag == "CO2")
        {
         Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "WrongGas" || collision.gameObject.tag == "CO2")
        {
        Destroy(collision.gameObject);
        }
    }


}
