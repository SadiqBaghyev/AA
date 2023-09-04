using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurningCircle : MonoBehaviour
{
    public float turnSpeed;

    private void Update()
    {
        transform.Rotate(0,0,turnSpeed*Time.deltaTime);
    }
}
