using UnityEngine;

public class DownMove : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void FixedUpdate()
    {
        transform.Translate(Vector3.down * _speed * Time.fixedDeltaTime);
    }
}