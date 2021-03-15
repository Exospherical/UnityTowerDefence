using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{

    public static BuildManager instance;
    public GameObject turretToBuild;
    public GameObject standardTurretPrefab;
    public GameObject secondTurretPrefab;

    public GameObject getTurretToBuild()
    {
        return turretToBuild;
    }

    private void Start()
    {
      //  turretToBuild = standardTurretPrefab;
    }

    private void Awake()
    {
        instance = this;
    }


    public void setTurretToBuild(GameObject turret)
    {
        turretToBuild = turret;
    }
}
