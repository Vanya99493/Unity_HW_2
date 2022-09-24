using UnityEngine;

[RequireComponent(typeof(PlayerController))]
public class PlayerCollisionController : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<ObstacleMarker>() != null)
        {
            GetComponent<PlayerController>().Damage(collision.gameObject.GetComponent<ObstacleMarker>().Damage);
        }
    }
}