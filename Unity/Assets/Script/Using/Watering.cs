using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watering : MonoBehaviour
{
    // Start is called before the first frame update

    //[SerializeField] GameObject myParticles;
    ParticleSystem part;
    AudioSource my_AudioSourse;
    void Start()
    {
        part = GetComponent<ParticleSystem>();
        my_AudioSourse = GetComponent<AudioSource>();
    }

    // Update is called once per frame  
    void Update()
    {

        //Debug.Log("Vector" + transform.rotation); 
        if (Vector3.Angle(Vector3.down, transform.forward) <= 60f)
        {
            part.Play();
            my_AudioSourse.Play();
        }
        else
        {
            part.Stop();
            my_AudioSourse.Stop();
        }
    }
}
