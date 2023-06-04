using UnityEngine;

namespace Internal_assets.Scripts
{
    public class TriggerSetUpAccelerationForSpeed : MonoBehaviour
    {
        [SerializeField] private float accelerationSpeed;
        
        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent<MoveAlongWaypoints>(out var moveAlongWaypoints))
            {
                Debug.Log($"OnTriggerEnter MoveAlongWaypoints");
                moveAlongWaypoints.SetAccelerationForSpeed(accelerationSpeed);
            }
        } 
    }
}