using UnityEngine;

public class TankModel
{
    private TankController m_tankController;

    public float movementSpeed;
    public float rotateSpeed;

    public TankModel(float moveSpeed, float rotateSpeed)
    {
        movementSpeed = moveSpeed;
        this.rotateSpeed = rotateSpeed;
    }
    public void SetController(TankController controller)
    {
        m_tankController = controller;
    }
}
