using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class copylocaleuler : MonoBehaviour
{
    [SerializeField] Transform copied;
    [SerializeField] Vector3 mults;
    void Update()
    {
        transform.localEulerAngles = Vector3.Scale(copied.localEulerAngles, mults);
    }
}
