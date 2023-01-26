using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float heldFrames;
    Vector3 originalPosition;
    Vector3 nextPosition;

    // Called before the first frame update
    void Start()
    {
        heldFrames = 0;
        originalPosition = gameObject.transform.position;
        nextPosition = originalPosition + Vector3.up;
    }

    // Called once per frame
    private void Update()
    {
        // The float variables, moveHorizontal and moveVertical, holds the value of the virtual axes, X and Z.

        if (Input.GetAxis("Vertical") > 0)
        {
            heldFrames += 1;
            if (heldFrames >= 60)
            {
                gameObject.transform.position = nextPosition;
            }    
        }
        else
        {
            heldFrames = 0;
            gameObject.transform.position = originalPosition;
        }
    }
}