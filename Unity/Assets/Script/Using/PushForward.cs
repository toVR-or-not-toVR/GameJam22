using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushForward : MonoBehaviour
{

    Rigidbody rb;
    [SerializeField] float speed = 1f;
    Vector3 co2;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // rb.AddForce(transform.forward);
        co2 = new Vector3(331.990021f, 81.8999863f, 4.43000031f);
    }

    private void FixedUpdate()
    {
        transform.position += -transform.forward * Time.deltaTime * speed;
    }

    // Update is called once per frame

}
