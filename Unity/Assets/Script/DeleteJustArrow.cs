using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace BNG
{
    public class DeleteJustArrow : MonoBehaviour
    {
        // Start is called before the first frame update
        [SerializeField] GameObject arrowObj;


        bool isGrabbed;
        Grabbable grabbable;
        // Start is called before the first frame update
        void Start()
        {
            isGrabbed = false;
            grabbable = GetComponent<Grabbable>();
        }

        // Update is called once per frame
        private void Update()
        {
            if (grabbable.BeingHeld && !isGrabbed)
            {
                isGrabbed = true;
                arrowObj.SetActive(false);           
            }
        }
    }
}
