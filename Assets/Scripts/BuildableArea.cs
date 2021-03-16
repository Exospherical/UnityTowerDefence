using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildableArea : MonoBehaviour
{

    public Color hovercolor;

    private Renderer rend;
    private Color startColor;
    public GameObject towerPreFab;
    BuildManager buildManager;

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

    //The tower object that is being built

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

        if(buildManager.getTurretToBuild() == null)
        {
            return;
        }

        if(!buildManager.canBuild)
        {
            return;
        }     

 
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
