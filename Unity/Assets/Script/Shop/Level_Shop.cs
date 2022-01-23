using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level_Shop : MonoBehaviour
{
    [SerializeField] int turbo_bust_score = 1000;
    [SerializeField] int win_score = 3000;

    [SerializeField] GameObject winObj;
    [SerializeField] GameObject generator;
    public int score;
    [SerializeField] Text text_score;
    [SerializeField] GameObject turboMode;
    [SerializeField] AudioClip turboAudio;
    [SerializeField] ItemThrower itemThrower;
    [SerializeField] ItemThrower itemThrowerTurbo;


   
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        text_score.text = score.ToString();
    }

    public void IncreaseScore(int score_i)
    {
        score = score + score_i;
        text_score.text = score.ToString();

        
        if (score >= win_score)
        {
            winObj.SetActive(true);
            text_score.text = "Win";
            generator.SetActive(false);
        }
        else if (score == turbo_bust_score || score == (turbo_bust_score + 1000))
        {
            StartCoroutine(StartTurboBust());
        }
    }

    public void DecreaseScore(int score_i)
    {
        score = score - score_i;
        text_score.text = score.ToString();
    }

    IEnumerator StartTurboBust()
    {
        generator.SetActive(false);
        yield return new WaitForSeconds(1.5f);
        AudioSource.PlayClipAtPoint(turboAudio, Camera.main.transform.position);
        yield return new WaitForSeconds(0.5f);
        turboMode.SetActive(true);
        itemThrowerTurbo.StartAgain();
        yield return new WaitForSeconds(2f);
        turboMode.SetActive(false);
        generator.SetActive(true);
        itemThrower.StartAgain();

    }



}
