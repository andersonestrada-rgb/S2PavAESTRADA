/*
3️⃣  🎮 Sistema de Jugador con Componentes
Crea una clase Player que tenga internamente 
un Health y un Weapon. El jugador debe poder
atacar a un enemigo utilizando su arma, sin 
acceder directamente a la vida del enemigo.
*/

using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private string PlayerName;
    [SerializeField] private Health health = new();
    [SerializeField] private Weapon weapon;
    [SerializeField] private float healAmount = 12f;

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log(PlayerName + " | Vida: " + health.GetLife());
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            health.Heal((int)healAmount);
        }
    }

    public void TakeDamage(int damage)
    {
        health.TakeDamage(damage);
    }

    // Ahora coherente con Weapon.Shoot(): no necesita objetivo directo, Weapon se encarga de instanciar la bala.
    public void Shoot()
    {
        if (weapon == null)
        {
            Debug.LogWarning("Player sin Weapon asignada.");
            return;
        }

        Debug.Log(PlayerName + " dispara!");
        weapon.Shoot();
    }
}