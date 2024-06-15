using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class BottleToOrigin : MonoBehaviour
{
   [SerializeField] private Pose originalPose;
   private XRGrabInteractable grabinteractable;

    

    private void Awake() {
    grabinteractable=GetComponent<XRGrabInteractable>();
    originalPose.position=transform.position;
    originalPose.rotation=transform.rotation;
   }
   /// <summary>
   /// This function is called when the object becomes enabled and active.
   /// </summary>
   /// <summary>
   /// This function is called when the object becomes enabled and active.
   /// </summary>
   /// 
   
   void OnEnable()
   {
       grabinteractable.selectExited.AddListener(BottleReleased);
   }
    /// <summary>
    /// This function is called when the behaviour becomes disabled or inactive.
    /// </summary>
    void OnDisable()
    {
        grabinteractable.selectExited.RemoveListener(BottleReleased);
    }
     private void BottleReleased(SelectExitEventArgs arg0)
    {
        transform.position=originalPose.position;
        transform.rotation=originalPose.rotation;
    }
    
   
}
