using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menumanager : MonoBehaviour
{
    public string currentmenuname = "mian";
    void Update()
    {
        foreach(Transform child in transform)
        {
            if(child.name == currentmenuname)
            {
                child.gameObject.SetActive(true);
            }
            else child.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    public void loadscene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
    public void changemenu(string name)
    {
        currentmenuname = name;
    }
}
