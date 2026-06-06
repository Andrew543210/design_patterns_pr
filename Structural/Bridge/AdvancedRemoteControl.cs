namespace DesignPatternsApp.Structural.Bridge;


public class AdvancedRemoteControl : RemoteControl
{
    public AdvancedRemoteControl(IDevice idevice) : base(idevice)
    {
    }

    public void Mute()
    {
        _device.SetVolume(0);
    }
}