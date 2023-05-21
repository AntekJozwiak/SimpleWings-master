using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reng : MonoBehaviour
{
    public bool finalreng;
    private void OnTriggerStay(Collider other)
    {
        if(other.transform.tag == "Player")
        {
            if(other.GetComponent<Rigidbody>().velocity.magnitude < 1f || !finalreng)
            {
                Destroy(this.gameObject);
                
            }
            
        }
    }
}
