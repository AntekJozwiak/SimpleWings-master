using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointer : MonoBehaviour
{
    [SerializeField] private float lengthdiv = 1000;
    [SerializeField] private Vector2 lengthcap;
    void Update()
    {
        GameObject[] rengs = GameObject.FindGameObjectsWithTag("renger");
        
        Vector3 lookat = Vector3.zero;
        float smalldis = Mathf.Infinity;
        foreach(GameObject r in rengs)
        {
            float dis = Vector3.Distance(transform.position, r.transform.position);
            if (dis < smalldis)
            {
                lookat = r.transform.position;
                smalldis = dis;
            }
        }
        transform.LookAt(lookat);
        transform.localScale = new Vector3(1, 1, Mathf.Clamp(smalldis / lengthdiv, lengthcap.x, lengthcap.y));
    }
}
