using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gas : MonoBehaviour
{

    [SerializeField] AudioClip destroySound;
    [SerializeField] GameObject parcitlesObg;

    [SerializeField] float timeToDestroy = 5f;
    [SerializeField] float volumeSounds = 0.7f;

    COLevel colevel;


    void Start()
    {
        Destroy(gameObject, timeToDestroy);
        colevel = FindObjectOfType<COLevel>();
    }



    private void OnTriggerEnter(Collider other)
    {

        //Debug.Log("Name " + other.gameObject.tag + other.gameObject  + gameObject.name);
        if (other.gameObject.name == "TreeSprout" || other.gameObject.name == "BodyCollider" || other.gameObject.tag == "Player")
        {
            Debug.Log(other.gameObject.name);
            AudioSource.PlayClipAtPoint(destroySound, transform.position, volumeSounds);
            GameObject particlesScene = Instantiate(parcitlesObg, transform.position, Quaternion.identity) as GameObject;
            Destroy(particlesScene, 0.1f);
            Destroy(gameObject, 0.05f);
            
            if (gameObject.tag == "WrongGas")
            {
                Debug.Log(0);
                colevel.DecreaseLevel();
                
            }

            if (gameObject.tag == "CO2")
            {
                colevel.IncreaseLevel();
                
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (gameObject.tag == "WrongGas")
        {
            AudioSource.PlayClipAtPoint(destroySound, transform.position, volumeSounds);
            GameObject particlesScene = Instantiate(parcitlesObg, transform.position, Quaternion.identity) as GameObject;
            Destroy(particlesScene, 0.1f);
            Destroy(gameObject, 0.05f);
            colevel.DecreaseLevel();

        }




    }
}
