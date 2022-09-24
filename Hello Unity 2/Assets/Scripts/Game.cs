using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private PlayerController _playerController;
    [SerializeField] private Spawner _spawner;

    [Header("Player settings")]
    [SerializeField] private float _playerHealth = 10;
    [SerializeField] private float _playerMoveSpeed = 10;

    private void Awake()
    {
        _spawner.Initialize();
        _playerController.Initialize(new Player(_playerHealth, _playerMoveSpeed));

        _playerController.Player.DieAction += StopSpawnObjects;
        _playerController.Player.DieAction += Lose;
    }

    private void StopSpawnObjects()
    {
        _spawner.StopSpawnCoroutine();
    }

    private void Lose()
    {
        Debug.Log("You lose");
    }
}