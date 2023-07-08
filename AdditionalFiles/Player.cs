using System;

class Player
{

    public delegate void HealthHandler(int health);
    public event HealthHandler? ActionHealth;

    private int health;

    public Player()
    {
        this.health = 100;
    }

    public void Heal(int heal)
    {
        this.health += heal;
        ActionHealth?.Invoke(this.health);
    }

    public void Damage(int damage)
    {
        this.health -= damage;
        ActionHealth?.Invoke(this.health);
    }

}