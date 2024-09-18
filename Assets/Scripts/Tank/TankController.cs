using UnityEngine;

public class TankController
{
    private TankModel tankModel;
    private TankView tankView;

    public TankController(TankModel _tankModel, TankView _tankView)
    {
        tankModel = _tankModel;
        tankView = GameObject.Instantiate<TankView>(_tankView);

        tankModel.SetController(this);
        tankView.SetController(this);
    }

    public void Move(float movement, float movementSpeed)
    {
        tankView.rb.velocity = tankView.transform.forward * movement * movementSpeed;
    }

    public void Rotate(float rotate, float rotateSpeed)
    {
        
    }

    public TankModel GetModel()
    {
        if (tankModel == null)
        {
            return tankModel;
        }
        else
            return null;
    }
}
