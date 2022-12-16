using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
 
    private void Start()
    {
        UnityEvents.current.OnDoorwayTriggerEnter += OnDoorwayOpen;
        UnityEvents.current.OnDoorwayTriggerExit += OnDoorwayClose;
    }

    private void OnDoorwayClose()
    {
        LeanTween.moveLocalY(gameObject, 9f, 1f).setEaseInQuad();
    }


    private void OnDoorwayOpen()
    {
        LeanTween.moveLocalY(gameObject, 10f, 1f).setEaseOutQuad();
    }


}
