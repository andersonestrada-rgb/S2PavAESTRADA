/*
3️⃣  🎮 Sistema de Jugador con Componentes
Crea una clase Player que tenga internamente 
un Health y un Weapon. El jugador debe poder
atacar a un enemigo utilizando su arma, sin 
acceder directamente a la vida del enemigo.
*/

using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Player : MonoBehaviour
{
    [SerializeField] private Player Target;
    [SerializeField] string PlayerName;
    [SerializeField] private Health health = new();
    [SerializeField] private Weapon weapon;


    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot(Target);//modificar
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log(PlayerName + "|");
            health.GetLife();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            health.Heal(12);
        }
    }
    public void TakeDamage(int damage)
    {
        health.TakeDamage(damage);
    }
    public void Shoot(Player Target)
    {

        Debug.Log(PlayerName + "|");
        weapon.Shoot(Target);
    }






    // public void TakeDamage(int damage) =>  health.TakeDamage(damage);
}