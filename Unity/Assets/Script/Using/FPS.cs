using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    // Start is called before the first frame update
using UnityEngine;
 using System.Collections;
 using UnityEngine.UI;
 
 public class   FPS : MonoBehaviour
{
    public Text fpsText;
    public float deltaTime;

    void Update()
    {
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
        float fps = 1.0f / deltaTime;
        fpsText.text = Mathf.Ceil(fps).ToString();
    }
}
