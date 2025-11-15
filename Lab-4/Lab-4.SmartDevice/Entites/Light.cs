using System.Security.Principal;

namespace Lab_4.SmartDevice.Entites;

public class Light : BaseEntity.SmartDevice
{
    private int _Brightness { get; set; }

    public int Brightness
    {
        get { return _Brightness; }
        set
        {
            if (value is > 100 or < 0)
            {
                Console.WriteLine("Value is out of range");
            }
            else
            {
                _Brightness = value;
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
        Console.WriteLine($"Brightness: {Brightness}, state :  {IsOn}");
    }
}