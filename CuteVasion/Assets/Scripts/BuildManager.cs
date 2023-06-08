using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    void Awake()
    { }
    
    public GameObject standardTurrentPrefab;
    public GameObject anotherTurrentPrefab;

    private GameObject turrentToBuild;

    public GameObject GetTurrentToBuild ()
    { 
        return turrentToBuild; 
    }

    public void SetTurrentBuild (GameObject turrent)
    {
        turrentToBuild = turrent; 
    }
}
