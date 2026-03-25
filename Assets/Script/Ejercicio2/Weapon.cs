/*
2️⃣ 🎮 Sistema de Ataque Controlado
Crea una clase Weapon que tenga un 
valor de daño y un método Attack(Health target). 
El arma debe aplicar daño llamando al método del 
objeto Health, evitando modificar directamente 
su vida.
*/

using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private int damage;
    [SerializeField] private int ammo = 10;

    void Start()
    {

    }

    public void Shoot2(Player target)
    {

        if (target == null || ammo <= 0)
        {
            Debug.Log("No tiene munición");
            return;
        }

        if (ammo >= 1)
        {
            target.TakeDamage(damage);
            ammo--;
            Debug.Log("Shoot");
        }
        else
        {
            Debug.Log("No tiene munición");
        }
    }




    public void Shoot(Player target)
    {
       
        if (target == null || ammo <= 0)
        {
            Debug.Log("No tiene munición");
            return;
        }
      
        if (ammo >= 1)
        {
            target.TakeDamage(damage);
            ammo--;
            Debug.Log("Shoot");
        }
        else
        {
            Debug.Log("No tiene munición");
        }       
    }
}