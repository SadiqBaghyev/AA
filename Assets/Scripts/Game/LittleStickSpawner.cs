using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LittleStickSpawner : MonoBehaviour
{

    public GameObject littleStick;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LittleSpawner();
        }

        void LittleSpawner()
        {
            //Instantiate - Respawner
            Instantiate(littleStick, transform.position, transform.rotation);
        }
    }

}
