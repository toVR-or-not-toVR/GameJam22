using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderCustom : MonoBehaviour
{
  




    public void LoadChapter2Scene(float timeToLoadScene)
    {
        StartCoroutine(WaitAndLoadScene(timeToLoadScene, "BitSaberScene"));
    }

    public void LoadThirdScene(float timeToLoad)
    {
        Debug.Log("Teleport");
        StartCoroutine(WaitAndLoadScene(timeToLoad, "ThreeScene"));
    }

    public void LoadIntroChapter()
    {
        StartCoroutine(WaitAndLoadScene(6f, "SmallScene"));
    }


    IEnumerator WaitAndLoadScene(float timeToLoad, string sceneName)
    {
        yield return new WaitForSeconds(timeToLoad);
        SceneManager.LoadScene(sceneName);
    }
}
