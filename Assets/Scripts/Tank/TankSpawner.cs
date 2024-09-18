using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [SerializeField] private TankView tankPrefab;

    void Start()
    {
        if(tankPrefab == null)
        {
            Debug.LogError("Tank Prefab is empty");
            return;
        }

        TankModel tankModel = new TankModel(20);
        TankController tankController = new TankController(tankModel, tankPrefab);
    }
}
