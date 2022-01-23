using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotShop : MonoBehaviour
{

    [SerializeField] GameObject bodyObj;
    public AudioClip audioToPlayStart;
    [SerializeField]  NewMouth newMouth;

    // Start is called before the first frame update
    void Start()
    {
        
        StarSpeakIntro();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    


   

    void StarSpeakIntro()
    {

        newMouth = FindObjectOfType<NewMouth>();
        AudioSource.PlayClipAtPoint(audioToPlayStart, transform.position, 1f);
        newMouth.MouthAnimation(audioToPlayStart.length);

    }


   
    


}
