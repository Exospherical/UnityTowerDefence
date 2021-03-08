using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildableArea : MonoBehaviour
{
    //The tower object that is being built
    public GameObject towerPreFab;

    private void OnMouseUpAsButton()
    {
        GameObject gameObject = (GameObject)Instantiate(towerPreFab);
        gameObject.transform.position = transform.position + Vector3.up;
    }
}
