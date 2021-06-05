using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotation : MonoBehaviour
{
    public Transform wheelRight, wheelLeft;

    public float rotationSpeed = 200f;

    public void RightWheelRotation()
    {
        wheelRight.Rotate(0f, 0f, -rotationSpeed * Time.deltaTime);
        wheelLeft.Rotate(0f, 0f, -rotationSpeed * Time.deltaTime);
    }
    public void LeftWheelRotation()
    {
        wheelRight.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
        wheelLeft.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
    }
    public void StopWheelRotation()
    {
        wheelRight.Rotate(0f, 0f, 0f);
        wheelLeft.Rotate(0f, 0f, 0f);
    }
}
