using System.Diagnostics.Tracing;
using Unity.VisualScripting;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private int damage;
    private int ammo;

    void Start()
    {
        
    }

    public void Shoot(Player target)
    {
        if (target == null || ammo == 0) return;
        
        if (ammo >= 1)
        {
            target.TakeDamage(damage);
            ammo--;
        }
        else if (ammo <= 0)
        {
            print("No tienes municion");
            return;
        }
    }







}
