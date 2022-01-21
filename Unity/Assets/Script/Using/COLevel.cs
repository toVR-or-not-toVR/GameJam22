using UnityEngine;
using UnityEngine.UI;

public class COLevel : MonoBehaviour
{

    private Image barLevel;
    public float currentLevel;
    public float maxBarLevel = 20;


    // Start is called before the first frame update
    void Start()
    {
        currentLevel = 0;
        barLevel = GetComponent<Image>();      
    }

    // Update is called once per frame
    void Update()
    {        
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
