using UnityEngine;

public class Health
{
    private int value;

    public void TakeDamage(int damage)
    {
        value -= damage;
        if (value < 0)
            value = 0;
        Debug.Log($"Daño{damage}");
    }

    public int GetLife()
    {
        return value;
    }





}