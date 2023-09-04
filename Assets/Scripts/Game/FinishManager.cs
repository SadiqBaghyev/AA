using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishManager : MonoBehaviour
{
    public GameObject BigCircle;
    public GameObject SpawnLocation;

    public void FinishGame()
    {
        BigCircle.GetComponent<TurningCircle>().enabled = false;
        
        SpawnLocation.GetComponent<LittleStickSpawner>().enabled = false;
    }
}
