
using UnityEngine;

public class Shop : MonoBehaviour
{


    
    public TurretFactory secondTurret; 
    BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void selectStandardTurret()
    {
        buildManager.selectTurretToBuild(standardTurret);
    }

    public void selectUpgradedTurret()
    {
        buildManager.selectTurretToBuild(secondTurret);


    }
}
