using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{

    public static BuildManager instance;
    private GameObject turretToBuild;
    public GameObject standardTurretPrefab;

    public GameObject getTurretToBuild()
    {
        return turretToBuild;
    }

    private void Start()
    {
        turretToBuild = standardTurretPrefab;
    }

    private void Awake()
    {
        instance = this;
    }
}
