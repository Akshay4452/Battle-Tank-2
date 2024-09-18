using UnityEngine;

public class TankModel
{
    private TankController m_tankController;

    public float movementSpeed;

    public TankModel(float moveSpeed)
    {
        movementSpeed = moveSpeed;
    }
    public void SetController(TankController controller)
    {
        m_tankController = controller;
    }
}
