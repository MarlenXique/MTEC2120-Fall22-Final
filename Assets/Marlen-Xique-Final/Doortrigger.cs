using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Doortrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        UnityEvents.current.DoorwayTriggerEnter ();
    }
}
