using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Range _playerMoveRange_x;

    public Player Player;

    public void Initialize(Player player)
    {
        if(player == null)
        {
            throw new System.Exception("Player is null");
        }

        Player = new Player(player.Health, player.MoveSpeed);
    }

    public void Damage(int damage)
    {
        Player.Damage(damage);
    }

    private void FixedUpdate()
    {
        if (!Player.IsAlive)
        {
            return;
        }

        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(new Vector3(
            -horizontalInput * Player.MoveSpeed * Time.fixedDeltaTime, 
            0f, 
            0f
            ));
    }
}