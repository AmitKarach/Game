using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovment : MonoBehaviour
{
    public Transform lookAt;
    public float boundX = 0.15f;
    public float boundY = 0.05f;


    public void LateUpdate()
    {
        Vector3 delta = Vector3.zero;

        // Calculate the difference in X and Y positions
        float deltaX = lookAt.position.x - transform.position.x;
        float deltaY = lookAt.position.y - transform.position.y;

        // Check bounds for X axis
        if (Mathf.Abs(deltaX) > boundX)
        {
            delta.x = (deltaX > 0) ? deltaX - boundX : deltaX + boundX;
        }

        // Check bounds for Y axis
        if (Mathf.Abs(deltaY) > boundY)
        {
            delta.y = (deltaY > 0) ? deltaY - boundY : deltaY + boundY;
        }

        // Apply the calculated delta to the position
        transform.position += delta;
    }

}
