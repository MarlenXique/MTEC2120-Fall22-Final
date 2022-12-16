using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class UnityEvents : MonoBehaviour
{
    public static UnityEvents current;
    void Start()
    {
        current = this;
        
    }

    public event Action onDoorwayTriggerEnter;
    public void DoortriggerEnter() 
    {
        if(onDoorwayTriggerEnter != null)
        {
            onDoorwayTriggerEnter();
        }
    }
}
