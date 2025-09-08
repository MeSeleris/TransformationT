using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;

    private void Update()
    {
        transform.Translate(transform.forward * _movementSpeed * Time.deltaTime, Space.Self);
    }
}
