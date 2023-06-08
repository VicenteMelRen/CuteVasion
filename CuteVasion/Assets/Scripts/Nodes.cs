using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nodes : MonoBehaviour
{
    public Color hoverColor;
    public Vector3 positionOffset;

    private GameObject turrent;

    private Renderer rend;
    private Color startColor;

    BuildManager buildManager;
    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

        buildManager = BuildManager.instance;
    }

    void OnMouseDown()
    {
        if (buildManager.GetTurrentToBuild() == null)
            return;

        if(turrent != null)
        {
            Debug.Log("Cant Build Here! -  TOD: Display on screen.");
            return;
        }

        GameObject turrentToBuild = buildManager.GetTurrentToBuild();
        turrent = (GameObject)Instantiate(turrentToBuild, transform.position + positionOffset, transform.rotation);
    }
    void OnMouseEnter()
    {
        if (buildManager.GetTurrentToBuild() == null)
            return;

        rend.material.color = hoverColor;
    }
    void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
