using UnityEngine;

public class TankModel
{
    private TankController m_tankController;

    public float m_movementSpeed;
    public float m_rotationSpeed;
    public Color m_tankColor;

    public TankModel(float moveSpeed, float rotateSpeed, Color tankColor)
    {
        m_movementSpeed = moveSpeed;
        m_rotationSpeed = rotateSpeed;
        m_tankColor = tankColor;
    }
    public void SetController(TankController controller)
    {
        m_tankController = controller;
    }
}
