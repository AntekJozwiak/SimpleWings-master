using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class creds : MonoBehaviour
{
    [SerializeField] private Text txt;

    private void Update()
    {
        txt.text = $"lvl: {PlayerPrefs.GetInt("creds", 0)}";
    }
}
