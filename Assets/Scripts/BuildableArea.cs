using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildableArea : MonoBehaviour
{

    public Color hovercolor;

    private Renderer rend;
    private Color startColor;
    public GameObject towerPreFab;


    private void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    //The tower object that is being built

    private void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = hovercolor;
    }

    private void OnMouseDown()
    {
        if (towerPreFab != null)
        {
            return;
        }

        GameObject turretToBuild = BuildManager.instance.getTurretToBuild();
        towerPreFab= (GameObject)Instantiate(turretToBuild, transform.position, transform.rotation);
    }

    private void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
