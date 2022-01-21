using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] Texture[] texturesBoard;
    [SerializeField] GameObject boardObj;
    Renderer boardRender;
    public float timeToSpeak = 3f;
    public float finishTime = 5f;
    [SerializeField] GameObject plane_1;
    [SerializeField] GameObject plane_2;
    [SerializeField] GameObject treeToAlive;
    [SerializeField] float timeToBoardBack = 5f;
    [SerializeField] Animator boardAnimator;
    [SerializeField] Animator botAnimator;
    [Header("TreeGrowth")]
    [SerializeField] GameObject treeObj;
    
   private float startTreeGrowth;

        
    BotSpeaking botSpeaking;

    
    // Start is called before the first frame update
    void Start()
    {


        boardRender = boardObj.GetComponent<Renderer>();        
         plane_2.SetActive(false);

        BotSpeaking botSpeaking = FindObjectOfType<BotSpeaking>();
        startTreeGrowth = botSpeaking.audioToPlay.length;
        //StartBoardAnimation


        //start Bot animation to move


        //Start animation for grouthPlant


        //Start speaking


        //ChangeBoardImage
        //StartCoroutine(ChangeImage());




    }

    public void StartWelcome()
    {
        StartCoroutine(StartPlaingAnimation(0f, "BoarMoveBack", boardAnimator));
        StartCoroutine(StartPlaingAnimation(0f, "BotMove", botAnimator));
        StartCoroutine(StarFunctionPlayBotSpeak(timeToSpeak));
        //StartCoroutine(StartPlaingAnimation(7f + startTreeGrowth , "TreeGrouth", botAnimator));
        StartCoroutine(TreeGrowth(7f + startTreeGrowth));
    }


    IEnumerator TreeGrowth(float timeToDo)
    {
        yield return new WaitForSeconds(timeToDo);
        treeObj.SetActive(true);
    }


    IEnumerator StarFunctionPlayBotSpeak(float timeToWait)
    {
        yield return new WaitForSeconds(timeToWait);        
        boardRender.material.color = Color.white;
        boardRender.material.mainTexture = texturesBoard[0];
        BotSpeaking botSpeaking = FindObjectOfType<BotSpeaking>();
        botSpeaking.PlaySpekingAnimation();
        yield return new WaitForSeconds(9f);
        boardRender.material.mainTexture = texturesBoard[1];  
        yield return new WaitForSeconds(7f);//16
        boardRender.material.mainTexture = texturesBoard[2];//23.5
        yield return new WaitForSeconds(7.5f);
        boardRender.material.mainTexture = texturesBoard[3];
        yield return new WaitForSeconds(8f);
        StartCoroutine(ChangeImage());

    }
    

    IEnumerator StartPlaingAnimation(float timeToPlay, string triggerAnimation, Animator animatorToPlay)
    {
        yield return new WaitForSeconds(timeToPlay);
        animatorToPlay.SetTrigger(triggerAnimation);        
    }

    IEnumerator ChangeImage()
    {
        yield return new WaitForSeconds(0f);
        boardAnimator.SetTrigger("BoardMoveToPlayer");
        boardRender.material.mainTexture = texturesBoard[4];
    }
}
