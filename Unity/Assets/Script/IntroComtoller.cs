using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroComtoller : MonoBehaviour
{

    SceneLoaderCustom sceneLoaderCustom;
    // Start is called before the first frame update
    void Start()
    {
        sceneLoaderCustom = FindObjectOfType<SceneLoaderCustom>();
        sceneLoaderCustom.LoadIntroChapter();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
