using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainBot : MonoBehaviour
{
    [SerializeField] GameObject bot;

    // Start is called before the first frame update
    void Start()
    {
        bot.SetActive(true);
    }

    void callBot() { bot.SetActive(true); }
    // Update is called once per frame
 
}
