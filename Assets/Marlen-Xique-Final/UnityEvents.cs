using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class UnityEvents : MonoBehaviour
{
    public static UnityEvents current;
    private void Awake()
    {
        current = this;
        
    }

    public event Action OnDoorwayTriggerEnter;
    public void DoorwayTriggerEnter() 
    {
        if(OnDoorwayTriggerEnter != null)
        {
            OnDoorwayTriggerEnter();
        }
    }
}
