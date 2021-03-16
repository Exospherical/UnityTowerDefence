
using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }
    public void buyStandardTurret()
    {
        buildManager.setTurretToBuild(buildManager.standardTurretPrefab);
    }

    public void buyUpgradedTurret()
    {
        buildManager.setTurretToBuild(buildManager.secondTurretPrefab);

    }
}
