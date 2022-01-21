using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterLevel : MonoBehaviour
{
    // Start is called before the first frame update
    private Image barLevel;
    public float currentLevel;
    public float maxBarLevel = 20;

  
    [SerializeField] GameObject particlesCollisonObj;
    [SerializeField] 

    ParticleCollision pacticlesCollision;
    Chapter3Controller chapter3Controller;
    bool isPlayed;


    // Start is called before the first frame update
    void Start()
    {
        isPlayed = false;
        chapter3Controller = FindObjectOfType<Chapter3Controller>();
        currentLevel = 0;
        barLevel = GetComponent<Image>();
        pacticlesCollision = particlesCollisonObj.GetComponent<ParticleCollision>();
    }

    // Update is called once per frame
    void Update()
    {
  
        if ( currentLevel >= maxBarLevel && !isPlayed)
        {
            isPlayed = true;
            chapter3Controller.WinSound();
            chapter3Controller.FinishWater();
            
            
        }
        currentLevel = pacticlesCollision.waterAmount;
        barLevel.fillAmount = currentLevel / maxBarLevel;
    }


    public void IncreaseLevel()
    {
        currentLevel++;
    }

    public void DecreaseLevel()
    {
        currentLevel--;
        if (currentLevel <= 0) { currentLevel = 0; }
    }
}
