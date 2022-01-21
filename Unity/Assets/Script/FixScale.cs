using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixScale : MonoBehaviour
{

    [SerializeField] float xScale = 1f;
    [SerializeField] float yScale = 1f;
    [SerializeField] float zScale = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(xScale, yScale, zScale);
       
    }




}
