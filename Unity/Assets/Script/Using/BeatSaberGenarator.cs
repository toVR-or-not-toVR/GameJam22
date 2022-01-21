using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatSaberGenarator : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] List<GameObject> objectToGenerate;
    [SerializeField] float timeToGenerateObjects = 2f;
    [SerializeField] int maxAmountOfObjectsOnScene = 10;
    public int numberOfObjects;


    [Header("Positions")]
    [SerializeField] float xPozRangeMin;
    [SerializeField] float xPozRangeMax;
    [SerializeField] float zPozRangeMin;
    [SerializeField] float zPozRangeMax;
    [SerializeField] float yPozRangeMin;
    [SerializeField] float yPozRangeMax;





    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GenerateObjects(timeToGenerateObjects));
    }




    //Coroutine to instantiate objects till there are amount on scene is less then allowed
    IEnumerator GenerateObjects(float timeToGerenate)
    {
        while (true)
        {
            yield return new WaitForSeconds(timeToGerenate);

            //get amount of objects Co2 on scene

            //no Need
/*            var objSeeker = GameObject.FindGameObjectsWithTag("CO2");
            numberOfObjects = objSeeker.Length;*/

/*            if (numberOfObjects < maxAmountOfObjectsOnScene) //Chenck amount on scene 
            {*/
                float xPoz = Random.Range(xPozRangeMin, xPozRangeMax);
                float zPoz = Random.Range(zPozRangeMin, zPozRangeMax);
                float yPoz = Random.Range(yPozRangeMin, yPozRangeMax);


                Instantiate(objectToGenerate[Random.Range(0,objectToGenerate.Count)], new Vector3(xPoz, yPoz, zPoz), Quaternion.identity);
            //}
        }
    }
}
