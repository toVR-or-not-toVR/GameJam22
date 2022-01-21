using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace BNG
{
    public class TreeArrowGrab : MonoBehaviour
    {
        [SerializeField] GameObject arrowObj;
        [SerializeField] GameObject hologramObj;

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
                hologramObj.SetActive(true);
                
            }
        }
    }
}