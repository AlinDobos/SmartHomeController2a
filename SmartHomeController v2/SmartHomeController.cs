using SmartHomeController;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

public class Program
{
    private static List<SmartDevice> devices = new List<SmartDevice>();
    public static void Main()
    {
        SmartLight kitchenLight = new SmartLight(1, "Kitchen Light", 20.5, "Blue");
        SmartThermostat bathroomThermostat = new SmartThermostat(2, "Bathroom Thermostat", 19, 25);
        SmartSpeaker livingRoomSpeaker = new SmartSpeaker(3, "Living Room Speaker", 20);
        SmartSecurityCamera frontDoorCamera = new SmartSecurityCamera(4, "Front Door Camera", "1080p");

        devices.Add(kitchenLight);
        devices.Add(bathroomThermostat);
        devices.Add(livingRoomSpeaker);
        devices.Add(frontDoorCamera);
    }

    public static void ViewAllDeviceStatuses()
    {
        Console.WriteLine("List of all Devices:");
        SmartDevice device=
    }


}
