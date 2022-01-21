using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotAndBoardContoller : MonoBehaviour
{
    [SerializeField] BoardAndBot boardAndBotInfo;
    [SerializeField] AudioClip botAudio;

     
    [SerializeField] GameObject boardPrefab;
    [SerializeField] GameObject botPrefab;


    GameObject boardImageUI;


    private void Start()
    {
        Image image;
        image = boardPrefab.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>();
       // image = boardImageUI.GetComponent<Image>();
        image.sprite = boardAndBotInfo.imageSprite;

        Instantiate(boardPrefab, boardAndBotInfo.boardTransform.transform.position, boardAndBotInfo.boardTransform.transform.rotation);
        GameObject bot  = Instantiate(botPrefab,
            boardAndBotInfo.BotTransform.transform.position,
            boardAndBotInfo.BotTransform.transform.rotation) as GameObject;
        //bot.GetComponent<Bot>().PlaySound(botAudio);
       
    }

}
