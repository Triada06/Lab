namespace Lab_4.SmartDevice.Entites;

public class SecurityCamera : BaseEntity.SmartDevice
{
    private string _Quality { get; set; }

    public string Quality
    {
        get { return _Quality; }
        set { _Quality = value; }
    }


    public override void TurnOff()
    {
        IsOn = false;
    }

    public override void TurnOn()
    {
        IsOn = true;
    }

    public override void ShowStatus()
    {
        Console.WriteLine($"Camera Quality: {Quality}, state :  {IsOn}");
    }
}