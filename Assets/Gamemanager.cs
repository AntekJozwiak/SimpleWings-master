using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    [SerializeField] private GameObject[] Airports;
    [SerializeField] private Transform[] Ringlocations;
    [SerializeField] private int lastlevel;
    [SerializeField] private int difficulty;
    private void Update()
    {
        if(transform.childCount <= 0)
        {
            for(int i = 0; i < Random.Range(0, difficulty))
            {

            }
        }
    }
}
