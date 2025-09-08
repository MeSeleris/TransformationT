using UnityEngine;

public class ObjectScale : MonoBehaviour
{
    [SerializeField] private Vector3 _scaleSpeed = new Vector3(0f, 0f, 0f);
    [SerializeField] private Vector3 _minScale = Vector3.one;
    [SerializeField] private Vector3 _maxScale = Vector3.one * 3f;

    void Update()
    {
        Vector3 newScale = transform.localScale + _scaleSpeed * Time.deltaTime;

        newScale = Vector3.Min(Vector3.Max(newScale, _minScale), _maxScale);

        transform.localScale = newScale;
    }
}
