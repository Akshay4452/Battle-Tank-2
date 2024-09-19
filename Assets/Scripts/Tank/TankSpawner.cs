using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [SerializeField] private TankView m_tankPrefab;
    private float m_tankMoveSpeed;
    private float m_tankRotateSpeed;

    void Start()
    {
        if(m_tankPrefab == null)
        {
            Debug.LogError("Tank Prefab is empty");
            return;
        }

        m_tankMoveSpeed = 20;
        m_tankRotateSpeed = 200;

        CreateTank();
    }

    private void CreateTank()
    {
        TankModel tankModel = new TankModel(m_tankMoveSpeed, m_tankRotateSpeed);
        TankController tankController = new TankController(tankModel, m_tankPrefab);
    }
}
