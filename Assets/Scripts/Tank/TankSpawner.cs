using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [SerializeField] private TankView m_tankPrefab;
    public TankType tankToSelect;

    [System.Serializable]
    public class Tank
    {
        public float moveSpeed;
        public float rotateSpeed;
        public TankType tankType;

        public Tank(float tankMoveSpeed, float tankRotateSpeed, TankType tankType)
        {
            moveSpeed = tankMoveSpeed;
            rotateSpeed = tankRotateSpeed;
            this.tankType = tankType;
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
        tankToSelect = TankType.GreenTank; // default tank - Green tank
        CreateTank();
    }

    private void CreateTank()
    {
        //int tankSelected = 0;  // To-Do: Link with UI

        Tank tank = tanksList[(int)tankToSelect];
        if (tank != null)
        {
            TankModel tankModel = new TankModel(tank.moveSpeed, tank.rotateSpeed);
            TankController tankController = new TankController(tankModel, m_tankPrefab);
        }
    }
}
