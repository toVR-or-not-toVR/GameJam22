using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Props : MonoBehaviour
{

    [SerializeField] List<AudioClip> destroySoundsShop;
    [SerializeField] List<AudioClip> FailSounds;
    
    [SerializeField] GameObject parcitlesObg;
    [SerializeField] bool isGood;
    [SerializeField] GameObject stain;

    [SerializeField] float volumeSounds = 0.7f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ShopCart")
        {
            if (isGood)
            {
                GoodFoodCached();
            }
            else
            {
                BadFoodCached();
            }
        }         
    }


    private void OnCollisionEnter(Collision collision)
    {
        FoodFailed();
    }


    void GoodFoodCached()
    {
        PlayGoodFoodSound();
        GameObject particlesScene = Instantiate(parcitlesObg, transform.position, Quaternion.identity) as GameObject;
        Destroy(particlesScene, 0.1f);        
        Destroy(gameObject, 0.05f);
    }

    void BadFoodCached()
    {
        PlayBadFoodSound();
        Destroy(gameObject, 0.1f);
    }

    void FoodFailed()
    {
        PlayFailFoodSound();
        Vector3 pos = new Vector3(transform.position.x, 0.446f, transform.position.z);
        GameObject stain_ins = Instantiate(stain, pos,   Quaternion.Euler(-90f, 0f, 0f)) as GameObject;
        Destroy(stain_ins, 2f);
        Destroy(gameObject, 0.1f);

    }





    //Sound
    void PlayGoodFoodSound()
    {
        AudioClip sound = destroySoundsShop[Random.RandomRange(0, destroySoundsShop.Count)];
        AudioSource.PlayClipAtPoint(sound, transform.position, volumeSounds);
    }

    void PlayBadFoodSound()
    {
        AudioClip sound = destroySoundsShop[Random.RandomRange(0, destroySoundsShop.Count)];
        AudioSource.PlayClipAtPoint(sound, transform.position, volumeSounds);
    }

    void PlayFailFoodSound()
    {
        AudioClip sound = FailSounds[Random.RandomRange(0, FailSounds.Count)];
        AudioSource.PlayClipAtPoint(sound, transform.position, volumeSounds);
    }

}
