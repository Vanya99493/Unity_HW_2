using UnityEngine;
public class ObstacleMarker : MonoBehaviour 
{
    [SerializeField] private int _damage;

    public int Damage { get { return _damage; } }
}