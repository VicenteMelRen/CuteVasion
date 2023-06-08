using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }
    public void PurchaseStandardTurrent()
    {
        Debug.Log("Standard Turrent Purchased");
        buildManager.SetTurrentBuild(buildManager.standardTurrentPrefab);
    }

    public void PurchaseAnotherTurrent() 
    {
        //Change this name to the gun when its finish
        Debug.Log("Another Turrent Purchased");
        buildManager.SetTurrentBuild(buildManager.anotherTurrentPrefab);
    }
    
    // We will need to put the third gun hehre
}
