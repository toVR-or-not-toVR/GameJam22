using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter3Controller : MonoBehaviour
{


   [SerializeField] Texture[] texturesBoard;
    public float timeToSpeak = 3f;
    public float finishTimeWelcom = 25f;
    [SerializeField] GameObject backGroundBoar;
    [SerializeField] GameObject WelcomText;
    [SerializeField] float timeToBoardBack = 5f;
    [SerializeField] Animator boardAnimator;
    [SerializeField] Animator botAnimator;

    [SerializeField] GameObject botObj;
    Renderer boardRender;
    BotChapterThree bot;
    [SerializeField] AudioClip winSound;


    [Header("TreePickUp")]
    [SerializeField] GameObject hologramTree;
    [SerializeField] GameObject arrowTree;
    

    

    [Header("WateringActivuty")]
    [SerializeField] GameObject waterHologram;
    [SerializeField] GameObject arrowWater;
    [SerializeField] GameObject waterLevel;


    [Header("Making Glucose")]
    [SerializeField] AudioClip botGlucose; 
    [SerializeField] GameObject sparklesParticles;

    [Header("SunActivity")]
    [SerializeField] GameObject sunPacticles;
    [SerializeField] float timeForSun = 10f;

    [Header("reaction")]
    [SerializeField] GameObject reactionObj;
    [SerializeField] float toToFinishReaction = 6f;
    [SerializeField] GameObject treeSprout;

    [Header("finalConrets")]
    [SerializeField] float timeToStartVideoBefore;
    [SerializeField] GameObject video; 
    [SerializeField] AudioSource backGroundMusic;

    
    // Start is called before the first frame update
    void Start()
    {
        boardRender = backGroundBoar.GetComponent<Renderer>();
        bot = botObj.GetComponent<BotChapterThree>();


        backGroundBoar.SetActive(true);
       
         


        //StartBoardAnimation
        StartCoroutine(StartPlaingAnimation(3f, "BoardBack_1", boardAnimator));

        //start Bot animation to move
        StartCoroutine(StartPlaingAnimation(0.1f, "ToPlayer_1", botAnimator));

        

        //Start speaking Start Speach
        StartCoroutine(ChapterStart());

        //ChangeBoardImage
        StartCoroutine(ChangeImage());


        

    }

    public void WinSound()
    {
        AudioSource.PlayClipAtPoint(winSound, Camera.main.transform.position);
    }



    public void WateringActivite()
    {
        waterLevel.SetActive(true);
        arrowWater.SetActive(true);
        boardRender.material.mainTexture = texturesBoard[1];
        waterHologram.SetActive(true);
    }

    public void FinishWater()
    {
        
        waterLevel.SetActive(false);
        StartGlucose();
    }


    public void StartGlucose()
    {        
        bot.PlayGlucoseSpeach();
       // AudioSource.PlayClipAtPoint(glucoseSound, sparklesParticles.transform.position);
        sparklesParticles.SetActive(true);
        StartCoroutine(FinishGlucose(9f));
    }


   
    IEnumerator Congrest()
    {
        bot.PrevCongretsSpeach();
        boardAnimator.SetTrigger("Video");
        yield return new WaitForSeconds(bot.prevCongrestsSound.length + 1f);

        backGroundMusic = FindObjectOfType<MusicController>().GetComponent<AudioSource>();        
        backGroundMusic.volume = 0f;

        video.SetActive(true);
        yield return new WaitForSeconds(92f);
        bot.FinalSpeach();


    }

    IEnumerator FinishGlucose(float timeToWait)
    {
        yield return new WaitForSeconds(timeToWait);
        sparklesParticles.SetActive(false);
        StartCoroutine(SunActivity(timeForSun));
    }

    IEnumerator SunActivity(float timeFoduration)
    {
        boardRender.material.mainTexture = texturesBoard[2];
        sunPacticles.SetActive(true);
        bot.PlaySunSpeach();
        yield return new WaitForSeconds(timeFoduration);
        sunPacticles.SetActive(false);

        StartCoroutine(StartReaction(toToFinishReaction));

    }


    IEnumerator StartReaction(float timeToFinish)
    {
        boardAnimator.SetTrigger("TreeReaction");
        botAnimator.SetTrigger("FromPlayer");
        yield return new WaitForSeconds(2f);
        reactionObj.SetActive(true);
        StartCoroutine(DeactivateTreeSprout());
        yield return new WaitForSeconds(timeToFinish);        
        WinSound();
        StartCoroutine(Congrest());
    }

    IEnumerator DeactivateTreeSprout()
    {
        yield return new WaitForSeconds(2f);
        treeSprout.SetActive(false);
    }



    IEnumerator StartPlaingAnimation(float timeToPlay, string triggerAnimation, Animator animatorToPlay)
    {
        yield return new WaitForSeconds(timeToPlay);
        animatorToPlay.SetTrigger(triggerAnimation);        
    }

    IEnumerator ChangeImage()
    {
        yield return new WaitForSeconds(finishTimeWelcom);
       
        boardRender.material.color = Color.white;
        boardRender.material.mainTexture = texturesBoard[0];
        arrowTree.SetActive(true);
        
    }


    IEnumerator ChapterStart()
    {
        yield return new WaitForSeconds(timeToSpeak);
        bot.PlayStartSpeach();
        //StartCoroutine(BotBack());
    }


    IEnumerator BotBack()
    {
        float timeToWait = bot.startSpeach.length;
        yield return new WaitForSeconds(timeToWait);
        botAnimator.SetTrigger("FromPlayer");
    }


  

}
