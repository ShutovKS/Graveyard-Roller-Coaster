using UnityEngine;
using PathCreation;
using UnityEngine.Serialization;

public class MoveAlongWaypoints : MonoBehaviour
{
    private Transform _transform;

    [SerializeField] private PathCreator pathCreator;
    [SerializeField] private float speedDefault = 5;
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

    public void ChangeSpeed(float newSpeed)
    {
        _speed *= 1 + newSpeed / 100;
    }
}