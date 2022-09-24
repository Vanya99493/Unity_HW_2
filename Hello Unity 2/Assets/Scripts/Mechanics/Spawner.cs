using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> _prefabs;
    [SerializeField] private float _startDelay;
    [SerializeField] private float _spawnDelay;
    [Header("Spawn position")]
    [SerializeField] private Range _xRangeSpawnPosition;
    [SerializeField] private float _ySpawnPosition;
    [SerializeField] private float _zSpawnPosition;

    private Coroutine _spawnCoroutine;

    public void Initialize()
    {
        _spawnCoroutine = StartCoroutine(SpawnObjects());
    }

    public void StopSpawnCoroutine()
    {
        StopCoroutine(_spawnCoroutine);
    }

    private IEnumerator SpawnObjects()
    {
        yield return new WaitForSeconds(_startDelay);

        while (true)
        {
            Instantiate(GetRandomPrefab(), GetRandomSpawnPosition(), Quaternion.identity);

            yield return new WaitForSeconds(_spawnDelay);
        }
    }

    private GameObject GetRandomPrefab()
    {
        return _prefabs.Count != 0 ? _prefabs[Random.Range(0, _prefabs.Count)] : new GameObject();
    }

    private Vector3 GetRandomSpawnPosition()
    {
        return new Vector3(
            Random.Range(_xRangeSpawnPosition.LowerLimit, _xRangeSpawnPosition.UpperLimit), 
            _ySpawnPosition,
            _zSpawnPosition
            );
    }
}