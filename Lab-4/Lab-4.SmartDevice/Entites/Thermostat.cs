namespace Lab_4.SmartDevice.Entites;

public class Thermostat : BaseEntity.SmartDevice
{
    private int _Temperature { get; set; }

    public int Temperature
    {
        get { return _Temperature; }
        set
        {
            if (value > 10 || value < 30)
            {
                _Temperature = value;
            }
            else
            {
                Console.WriteLine("Temperature must be between 0 and 30");
            }
        }
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
        Console.WriteLine($"Temperature: {_Temperature}, state :  {IsOn}");
    }
}