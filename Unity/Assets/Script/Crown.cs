using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace BNG
{
    public class Crown : MonoBehaviour
    {
       
        bool isGrabbed;
        Grabbable grabbable;        
        Rigidbody rb;
        Animator animator;
        

        private void Start()
        {
            
            isGrabbed = false;
            grabbable = GetComponent<Grabbable>();
            rb = GetComponent<Rigidbody>();;
            rb.isKinematic = true;
            animator = GetComponent<Animator>();
          
            StartCoroutine(StopAnimation());
           
        }

        private void Update()
        {

            if (grabbable.BeingHeld && !isGrabbed)
            {
                isGrabbed = true;
                
            }

            if (isGrabbed)
            {
                rb.isKinematic = false;
            }
            
        }

        IEnumerator StopAnimation()
        {
            yield return new WaitForSeconds(2.5f);
            animator.enabled = false;
            
        }

   



    }
}
