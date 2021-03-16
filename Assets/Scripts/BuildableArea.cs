using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildableArea : MonoBehaviour
{

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
    }

    //The tower object that is being built

    private void OnMouseEnter()
    {
<<<<<<< Updated upstream
=======
        if (!buildManager.canBuild)
        {
            return;
        }
>>>>>>> Stashed changes
        GetComponent<Renderer>().material.color = hovercolor;
    }

    private void OnMouseDown()
    {
<<<<<<< Updated upstream
        if (towerPreFab != null)
=======
        if(!buildManager.canBuild)
        {
            return;
        }     

        if(towerPreFab = null)
>>>>>>> Stashed changes
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
