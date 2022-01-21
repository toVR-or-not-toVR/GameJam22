using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Co2Push : MonoBehaviour
{


    Rigidbody rb;
    [SerializeField] float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        transform.position += (transform.right)  * Time.deltaTime * speed;
    }
}
