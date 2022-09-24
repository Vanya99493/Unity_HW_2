public class Player
{
    public float Health { get; private set; }
    public float MoveSpeed { get; private set; }
    public bool IsAlive { get; private set; }

    public event MyDelegate DieAction;

    public Player(float health, float moveSpeed)
    {
        IsAlive = true;
        Health = health;
        MoveSpeed = moveSpeed;
    }

    public void Damage(int damage)
    {
        if (!IsAlive)
        {
            return;
        }

        Health -= damage;

        if (Health <= 0)
        {
            IsAlive = false;
            DieAction?.Invoke();
        }
    }
}