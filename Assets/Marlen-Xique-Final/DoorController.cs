using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
 
    private void Start()
    {
        UnityEvents.current.onDoorwayTriggerEnter += OnDoorwayOpen;
    }
    private void OnDoorwayOpen()
    {
        //LeanTween.moveLoacalY(gameObject, 1.6, 1f).setEaseOutQuad();
    }

   
}
