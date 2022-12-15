using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Reaktion;

public class CustomGear : MonoBehaviour
{
    public ReaktorLink reaktor;
    public GameObject rock1;
    public GameObject rock2;
    public GameObject rock3;
    public GameObject rock4;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float val = reaktor.Output;
        float colorval = reaktor.Output;
        rock1.transform.position = new Vector3(63, val, 9);
        rock2.transform.position = new Vector3(73, val, 57);
        rock3.transform.position = new Vector3(10, val, 18);
        rock4.transform.position = new Vector3(45, val, 20);



    }
}
