using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerBeatSaber : MonoBehaviour
{

    public float timeToSpeak = 3f;
    public float finishTime = 5f;
    [SerializeField] GameObject plane_1;
    [SerializeField] GameObject plane_2;

    [SerializeField] float timeToBoardBack = 5f;
    [SerializeField] Animator boardAnimator;
    [SerializeField] Animator botAnimator;

    [SerializeField] float StartCrownAppear;
    [SerializeField] GameObject moleculesGenerator;
    [SerializeField] float timeStartActivateGenetarot;

    [SerializeField] AudioClip congratsSound;
    [SerializeField] GameObject particles;
    [SerializeField] GameObject crawn;
    [SerializeField] BeatSAberBot beatSAberBot;
    [SerializeField] AudioClip crownSound;

    [SerializeField] float timeBeforeCrown;
    [SerializeField] AudioClip deserveCrown;
         
    BotSpeaking botSpeaking;

    COLevel coLevel;
    SceneLoaderCustom sceneLoaderCustom;


    private bool isDone;
    
    // Start is called before the first frame update
    void Start()
    {
        BeatSAberBot botSpeaking = FindObjectOfType<BeatSAberBot>();
        plane_1.SetActive(true);
         plane_2.SetActive(false);

        isDone = false;
        coLevel = FindObjectOfType<COLevel>();
        beatSAberBot = FindObjectOfType<BeatSAberBot>();
        sceneLoaderCustom = FindObjectOfType<SceneLoaderCustom>();

        //StartBoardAnimation
        StartCoroutine(StartPlaingAnimation(timeToBoardBack, "FromPlayer", boardAnimator));

        //start Bot animation to move
        StartCoroutine(StartPlaingAnimation(1f, "ToPlayer_1", botAnimator));

        //Start animation for grouthPlant
        StartCoroutine(StartPlaingAnimation(StartCrownAppear, "TreeGrouth", botAnimator));

        //Start speaking
        StartCoroutine(StarFunctionPlayBotSpeak(timeToSpeak));

        //ChangeBoardImage
        StartCoroutine(ChangeImage());

        //Start generete CO2generator
        StartCoroutine(ActivateGameObject(timeStartActivateGenetarot, moleculesGenerator));
    }

    IEnumerator StarFunctionPlayBotSpeak(float timeToWait)
    {
        yield return new WaitForSeconds(timeToWait);
        BeatSAberBot botSpeaking = FindObjectOfType<BeatSAberBot>();
        botSpeaking.PlaySpekingAnimation();
    }
    

    IEnumerator StartPlaingAnimation(float timeToPlay, string triggerAnimation, Animator animatorToPlay)
    {
       // crawn.SetActive(true);
        yield return new WaitForSeconds(timeToPlay);
        animatorToPlay.SetTrigger(triggerAnimation);        
    }

    IEnumerator ChangeImage()
    {
        yield return new WaitForSeconds(finishTime);
        //boardAnimator.SetTrigger("ToPlayer");
        plane_1.SetActive(false);
        plane_2.SetActive(true);
    }

    IEnumerator ActivateGameObject(float timeToActivate, GameObject gameToActivate)
    {
        yield return new WaitForSeconds(timeToActivate);
        gameToActivate.SetActive(true);
    }


    

    IEnumerator CrownApear()
    {
        botAnimator.SetTrigger("ToPlayer_finall");
        AudioSource.PlayClipAtPoint(deserveCrown, Camera.main.gameObject.transform.position);
        yield return new WaitForSeconds(4f);
        crawn.SetActive(true);
        yield return new WaitForSeconds(4f);
        beatSAberBot.PlayCongrats();
        yield return new WaitForSeconds(1f);
        sceneLoaderCustom.LoadThirdScene(beatSAberBot.audioToPlaycongrats.length);
    }


    private void Update()
    {
        if (coLevel.currentLevel >= coLevel.maxBarLevel && !isDone)
        {
            isDone = true;
            Destroy(moleculesGenerator);
            AudioSource.PlayClipAtPoint(crownSound, Camera.main.transform.position);
            particles.SetActive(true);            
            StartCoroutine(CrownApear());

        }
    }
}
