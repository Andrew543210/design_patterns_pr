namespace DesignPatternsApp.Structural.Bridge;

public class Radio : IDevice
{
    private bool _isEnabled = false;
    
    private int _volume;

    public bool IsEnabled()
    {
        return _isEnabled;
    }

    public void Enable()
    {
        _isEnabled = true;
        _volume = 10;
        Console.WriteLine( "Radio is enabled");
    }
    public void Disable()
    {
        _volume = 0;
        _isEnabled = false;
        Console.WriteLine( "Radio is disabled");
    }

    public int GetVolume()
    {
        return _volume;
    }

    public void SetVolume(int volume)
    {
        _volume = volume;
        Console.WriteLine($"Radio volume set to {_volume}");
    }
}