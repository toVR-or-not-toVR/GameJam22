using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chiken : MonoBehaviour
{

    [SerializeField] GameObject pointToMove;
    // Start is called before the first frame update
    Rigidbody m_Rigidbody;
    public float m_Speed = 5f;

    void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        m_Rigidbody = GetComponent<Rigidbody>();
    }



    void FixedUpdate()
    {
        //Store user input as a movement vector
        Vector3 newVector = pointToMove.transform.position - transform.position;

        //Apply the movement vector to the current position, which is
        //multiplied by deltaTime and speed for a smooth MovePosition
        m_Rigidbody.MovePosition(transform.position + newVector * Time.deltaTime * m_Speed);
    }
}
