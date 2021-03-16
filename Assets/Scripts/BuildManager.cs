﻿using System.Collections;
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

    public void setTurretToBuild(GameObject turret)
    {
        turretToBuild = turret;
    }


    public bool canBuild { get { return turretToBuild != null; } }


    public void selectTurretToBuild(TurretFactory turret)
    {
        turretToBuild = turret;
    }

    public void buildTurretHere(BuildableArea buildableArea)
    {
        if(PlayerStatistics.points < turretToBuild.costToBuild)
        {
            return;
        }

        PlayerStatistics.points -= turretToBuild.costToBuild;

      GameObject turret =  (GameObject)Instantiate(turretToBuild.turret, buildableArea.getBuildPosition(), Quaternion.identity);
        buildableArea.towerPreFab = turret;
    }

}
