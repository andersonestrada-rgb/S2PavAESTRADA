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

    // Apply damage to this enemy. Other classes must use this method instead of modifying health directly.
    public void TakeDamage(int damage)
    {
        health.TakeDamage(damage);
    }

    // Returns true if the enemy has no life left.
    public bool IsDead()
    {
        return health.GetLife() <= 0;
    }

    // Optional: expose current life as read-only.
    public int GetLife()
    {
        return health.GetLife();
    }

}
