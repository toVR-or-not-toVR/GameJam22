using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level_Shop : MonoBehaviour
{

    public int score;
    [SerializeField] Text text_score;


    [SerializeField]  
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
    }

    public void DecreaseScore(int score_i)
    {
        score = score - score_i;
        text_score.text = score.ToString();
    }



}
