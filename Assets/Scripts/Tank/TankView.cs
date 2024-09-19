using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController m_tankController;

    #region Tank Movement Variables
    private float movement;
    private float rotation;
    #endregion 

    public Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("No rigid body for tank exists");
        }
    }

    public void SetController(TankController tankController)
    {
        m_tankController = tankController;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        movement = Input.GetAxis("Vertical");
        rotation = Input.GetAxis("Horizontal");

        if (movement != 0)
        {
            m_tankController.Move(movement, m_tankController.GetModel().movementSpeed);
        }

        if(rotation != 0)
        {
            m_tankController.Rotate(rotation, m_tankController.GetModel().rotateSpeed);
        }
    }
}
