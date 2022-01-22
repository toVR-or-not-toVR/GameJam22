using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObj : MonoBehaviour
{


    [SerializeField] List<GameObject> objectToGenerate;
    [SerializeField] float timeToGenerateObjects = 2f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GenerateObjects(timeToGenerateObjects));
    }

    // Update is called once per frame
    void Update()
    {
        
    }



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



            Instantiate(objectToGenerate[Random.Range(0, objectToGenerate.Count)], transform.position, Quaternion.identity);
            //}
        }
    }
}
