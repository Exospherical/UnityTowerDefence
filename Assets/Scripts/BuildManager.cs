using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{

    public static BuildManager instance;

    public TurretFactory turretToBuild;

    public GameObject standardTurretPrefab;
    public GameObject secondTurretPrefab;

    private void Start()
    {

        turretToBuild.turret = standardTurretPrefab;

    }

    private void Awake()
    {
        instance = this;
    }


    public bool canBuild { get { return turretToBuild != null; } }


    public void selectTurretToBuild(TurretFactory turret)
    {
        turretToBuild = turret;
    }

    public void buildTurretHere(BuildableArea buildableArea)
    {
        
      GameObject turret =  (GameObject)Instantiate(turretToBuild.turret, buildableArea.getBuildPosition(), Quaternion.identity);
        buildableArea.towerPreFab = turret;
    }

}