using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    [SerializeField] private Transform[] Airports;
    [SerializeField] private Transform[] Ringlocations;
    [SerializeField] private GameObject reng;
    [SerializeField] private int numrings;
    [SerializeField] private float expenentialmount;
    [SerializeField] private int lastlevel;
    [SerializeField] private int completionbonus;
    private void Start()
    {

    }
    int randonum = 0;
    private void Update()
    {
        if (transform.childCount == 1)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
        if (transform.childCount <= 0)
        {
            int points = PlayerPrefs.GetInt("creds", 0);
            points += Mathf.RoundToInt(Mathf.Pow(Mathf.Clamp(randonum,0f,100f),expenentialmount));
            Debug.Log(randonum);
            PlayerPrefs.SetInt("creds", points);
            randonum = (PlayerPrefs.GetInt("creds", 0) + 4) / 2;
            Debug.Log((PlayerPrefs.GetInt("creds", 0) + 4) / 2);
            for (int i = 0; i < (PlayerPrefs.GetInt("creds",0)+4)/2 && i < Ringlocations.Length; i++)
            {
                Transform mraids = Ringlocations[Random.Range(0, Ringlocations.Length)];
                Instantiate(reng, mraids.position, mraids.rotation).transform.parent = transform;
            }
            Transform airport = Airports[Random.Range(0, Airports.Length)];
            GameObject port = Instantiate(reng, airport.position, airport.rotation);
            port.transform.parent = transform;
            port.GetComponent<reng>().finalreng = true;
            port.SetActive(false);
        }
        
    }
}
