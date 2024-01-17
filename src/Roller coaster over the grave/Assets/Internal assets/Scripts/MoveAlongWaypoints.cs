using UnityEngine;
using PathCreation;

public class MoveAlongWaypoints : MonoBehaviour
{
    private Transform _transform;

    [SerializeField] private PathCreator pathCreator;
    [SerializeField] private float speedDefault;
    private float _speed;
    private float _distanceTravelled;

    private void OnEnable()
    {
        _transform = transform;
        _speed = speedDefault;
    }
    
    private void Update()
    {
        _distanceTravelled += _speed * Time.deltaTime;
        _transform.position = pathCreator.path.GetPointAtDistance(_distanceTravelled);
        _transform.rotation = pathCreator.path.GetRotationAtDistance(_distanceTravelled);
    }

    public void SetAccelerationForSpeed(float accelerationSpeed)
    {
        _speed = speedDefault * (accelerationSpeed <= 0 ? 1 : accelerationSpeed);
    }
}