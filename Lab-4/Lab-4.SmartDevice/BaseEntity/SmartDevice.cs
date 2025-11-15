namespace Lab_4.SmartDevice.BaseEntity;

public abstract class SmartDevice
{
    public string Name { get; set; }
    public bool IsOn { get; set; }
    
    public abstract void TurnOff(); 
    public abstract void TurnOn();
    public abstract void ShowStatus();
}