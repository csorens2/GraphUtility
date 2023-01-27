using GraphLibraries.BarGraph;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BarGraphCube : MonoBehaviour
{
    private static int delayStartup = 0;
    private static bool moved = false;

    public Material planeMaterial;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(delayStartup <= 60)
        {
            delayStartup += 1;
            return;
        }
        else if (!moved)
        {
            gameObject.transform.position += Vector3.up;

            GameObject plane = GameObject.CreatePrimitive(PrimitiveType.Plane);
            plane.transform.position = gameObject.transform.position + Vector3.up;
            plane.GetComponent<MeshRenderer>().material = planeMaterial;
            plane.transform.localScale = new Vector3(3, 3, 3);


            // Using position -10-10
            GameObject middleBar = GameObject.CreatePrimitive(PrimitiveType.Cube);
            middleBar.transform.parent = plane.transform;
            middleBar.transform.localScale = new Vector3(1, 10, 1);
            middleBar.GetComponent<MeshRenderer>().material = planeMaterial;


            moved = true;
        }

        //Debug.Log("Debug works");
    }
}



