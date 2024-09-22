using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class TankController
{
    private TankModel m_tankModel;
    private TankView m_tankView;

    public TankController(TankModel _tankModel, TankView _tankView)
    {
        m_tankModel = _tankModel;
        m_tankView = GameObject.Instantiate<TankView>(_tankView);

        m_tankModel.SetController(this);
        m_tankView.SetController(this);

        SetTankColor(m_tankModel.m_tankColor);
    }

    public void Move(float movement, float movementSpeed)
    {
        m_tankView.rb.velocity = m_tankView.transform.forward * movement * movementSpeed;
    }

    public void Rotate(float rotate, float rotateSpeed)
    {
        m_tankView.transform.Rotate(Vector3.up * rotate * rotateSpeed * Time.deltaTime);
    }

    public TankModel GetModel()
    {
        return m_tankModel;
    }

    public void SetTankColor(Color colorToSet)
    {
        Transform tankRenderers = m_tankView.transform.GetChild(0);
        foreach(Transform child in tankRenderers.GetComponentInChildren<Transform>())
        {
            MeshRenderer mr = child.gameObject.GetComponent<MeshRenderer>();
            mr.material.color = colorToSet;
        }
    }
}
