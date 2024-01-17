#region

using ChairControl.ChairWork;
using ChairControl.ChairWork.Options;
using UnityEngine;

#endregion

public class FutuRiftControllerManager : MonoBehaviour
{
    private FutuRiftController _futuRiftController;

    private void Update()
    {
        var euler = transform.eulerAngles;
        _futuRiftController.Pitch = -(euler.x > 180 ? euler.x - 360 : euler.x);
        _futuRiftController.Roll = -(euler.z > 180 ? euler.z - 360 : euler.z);
    }
    
    private void OnEnable()
    {
        _futuRiftController = new FutuRiftController(
            new UdpOptions
            {
                // ip = "192.168.50.126",  // ip компьютера, на котором запущен контроллер (не локальный)
                ip= "127.0.0.1",            // докальный
                port = 6065             // порт, на который настроен контролле
            });

        _futuRiftController.Start();
    }

    private void OnDisable()
    {
        _futuRiftController.Stop();
    }
}
