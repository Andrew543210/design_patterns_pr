namespace DesignPatternsApp.Structural.Bridge;

public class RemoteControl
{
    protected IDevice _device;

    public RemoteControl(IDevice idevice)
    {
        this._device = idevice;
    }

    public void TogglePower()
    {
        if (_device.IsEnabled())
        {
            _device.Disable();
        }
        else
        {
            _device.Enable();
        }
    }
    public void SetVolume(int volume)
    {
        _device.SetVolume(volume);
    }
}