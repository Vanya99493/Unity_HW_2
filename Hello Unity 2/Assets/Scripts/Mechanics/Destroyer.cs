using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<ObstacleMarker>() != null)
        {
            Destroy(other.gameObject);
        }
    }
}