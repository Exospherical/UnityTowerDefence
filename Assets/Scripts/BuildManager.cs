using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{

    public static BuildManager instance;
<<<<<<< Updated upstream
    private GameObject turretToBuild;
=======
    public TurretFactory turretToBuild;
>>>>>>> Stashed changes
    public GameObject standardTurretPrefab;

    private void Start()
    {
<<<<<<< Updated upstream
        turretToBuild = standardTurretPrefab;
=======
        turretToBuild.turret = standardTurretPrefab;
>>>>>>> Stashed changes
    }

    private void Awake()
    {
        instance = this;
    }
<<<<<<< Updated upstream
=======

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
>>>>>>> Stashed changes
}
