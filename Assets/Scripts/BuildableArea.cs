using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildableArea : MonoBehaviour
{
    BuildManager buildManager;
    public Color hovercolor;

    private Renderer rend;
    private Color startColor;
    public GameObject towerPreFab;

    public Vector3 getBuildPosition()
    {
        return transform.position;
    }
    private void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
        buildManager = BuildManager.instance;
    }


    private void OnMouseEnter()
    {

        if (!buildManager.canBuild)
        {
            return;
        }

        GetComponent<Renderer>().material.color = hovercolor;
    }

    private void OnMouseDown()
    {
        
        if(!buildManager.canBuild)
        {
            return;
        }     


        
        if(towerPreFab != null)

        {
            return;
        }

        buildManager.buildTurretHere(this);
    }

    private void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}