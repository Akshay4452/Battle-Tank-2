using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [SerializeField] private TankView m_tankPrefab;
    public TankType tankToSelect;  // Link with Ui

    [System.Serializable]
    public class Tank
    {
        public float moveSpeed;
        public float rotateSpeed;
        public TankType tankType;
        public Color tankColor;

        public Tank(float tankMoveSpeed, float tankRotateSpeed, TankType tankType, Color color)
        {
            moveSpeed = tankMoveSpeed;
            rotateSpeed = tankRotateSpeed;
            this.tankType = tankType;
            tankColor = color;
        }
    }

    public List<Tank> tanksList = new List<Tank>();

    void Start()
    {
        if(m_tankPrefab == null)
        {
            Debug.LogError("Tank Prefab is empty");
            return;
        }
        CreateTank();
    }

    private void CreateTank()
    {
        Tank tank = tanksList[(int)tankToSelect];
        switch (tankToSelect)
        {
            case TankType.GreenTank:
                tank.tankColor = Color.green;
                break;
            case TankType.BlueTank:
                tank.tankColor = Color.blue;
                break;
            case TankType.RedTank:
                tank.tankColor = Color.red;
                break;
        }

        TankModel tankModel = new TankModel(tank.moveSpeed, tank.rotateSpeed, tank.tankColor);
        TankController tankController = new TankController(tankModel, m_tankPrefab);
        
    }
}
