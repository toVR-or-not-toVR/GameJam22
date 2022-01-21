using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace BNG { 
    public class MoveToChapter1 : MonoBehaviour
    {

        SceneLoaderCustom sceneLoader;
        BotSpeaking botSpeaking;
       
        bool isGrabbed;
        Grabbable grabbable;
        [SerializeField] BoxCollider botCollider;
        private void Start()
        {
            isGrabbed = false;
            sceneLoader = FindObjectOfType<SceneLoaderCustom>();
            botSpeaking = FindObjectOfType<BotSpeaking>();
            grabbable = GetComponent<Grabbable>();
           

        }

    public void MoveToChapter()
    {
            botSpeaking.PlayCongersSpeatch();
            sceneLoader.LoadChapter2Scene(botSpeaking.doneSound.length + 0.5f);
    }



        private void Update()
        {
            if (grabbable.BeingHeld && !isGrabbed)
            {
                botCollider.enabled = false;
                isGrabbed = true;
                MoveToChapter();
            }
        }




    } }


