using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pot : MonoBehaviour
{

    [SerializeField] GameObject tree;
    [SerializeField] GameObject hologramTree;

    Chapter3Controller chapter3Controller;


    private void Start()
    {
        chapter3Controller = FindObjectOfType<Chapter3Controller>();
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "TreeSprout")
        {
            Destroy(other.gameObject);
            tree.SetActive(true);
            hologramTree.SetActive(false);

            chapter3Controller.WateringActivite();
            chapter3Controller.WinSound();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "TreeSprout")
        {
            Destroy(collision.gameObject);
            tree.SetActive(true);
            hologramTree.SetActive(false);

            chapter3Controller.WateringActivite();
            chapter3Controller.WinSound();

        }
    }
}



