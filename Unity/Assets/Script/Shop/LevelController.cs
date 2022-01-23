using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{

    [SerializeField] Texture[] texturesBoard;
    [SerializeField] GameObject boardObj;
    [SerializeField] GameObject botObj;
    [SerializeField] GameObject mainBot;
    Renderer boardRender;
    [SerializeField] GameObject plane_1;
    [SerializeField] GameObject plane_2;
    [SerializeField] Animator boardAnimator;
    [SerializeField] Animator botAnimator;
    // Start is called before the first frame update
    void Start()
    {
        boardRender = plane_2.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void StartInstruction()
    {
        //Change Board screen
        plane_1.SetActive(false);
        boardRender.material.mainTexture = texturesBoard[0];
        plane_2.SetActive(true);

        //actovate Bot
        mainBot.SetActive(true);
    }
}
