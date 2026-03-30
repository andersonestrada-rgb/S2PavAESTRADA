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
    [SerializeField] private int damage = 5;
    [SerializeField] private int ammo = 10;

    [Header("Bullet")]
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float bulletSpeed = 8f;

    void Start()
    {
    }

    // Instancia una bala, le asigna daño/velocidad y la dispara desde firePoint.
    public void Shoot()
    {
        if (bulletPrefab == null)
        {
            Debug.LogWarning("No se ha asignado bulletPrefab en Weapon.");
            return;
        }

        if (firePoint == null)
        {
            Debug.LogWarning("No se ha asignado firePoint en Weapon.");
            return;
        }

        if (ammo <= 0)
        {
            Debug.Log("No tiene munición");
            return;
        }

        var bulletObj = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        var bulletComp = bulletObj.GetComponent<Bullet>();
        if (bulletComp != null)
        {
            bulletComp.Init(damage, bulletSpeed);
        }

        ammo--;
        Debug.Log("Munición restante: " + ammo);
    }
}