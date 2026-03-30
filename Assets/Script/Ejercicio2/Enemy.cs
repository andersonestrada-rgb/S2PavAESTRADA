/*
4🎮Sistema de Enemigo Seguro
Crea una clase Enemy que tenga 
una variable privada de vida. 
Implementa métodos para recibir 
daño y verificar si está muerto. 
Ninguna otra clase debe modificar 
su vida directamente.
*/

using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Health health = new();

    void Start()
    {
    }

    void Update()
    {
    }

    public void TakeDamage(int damage)
    {
        health.TakeDamage(damage);

        int currentLife = health.GetLife();
        Debug.Log($"{name} recibió {damage} de daño. Vida restante: {currentLife}");

        if (currentLife <= 0)
        {
            Die();
        }
    }

    public bool IsDead()
    {
        return health.GetLife() <= 0;
    }

    public int GetLife()
    {
        return health.GetLife();
    }

    private void Die()
    {
        Debug.Log($"{name} ha muerto.");
        Destroy(gameObject);
    }
}
