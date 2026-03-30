/*
1️⃣ 🎮Sistema de Vida Encapsulada
Crea una clase Health que tenga 
una variable privada de vida. 
Implementa métodos para recibir 
daño y curarse. La vida no debe 
poder modificarse directamente desde 
otras clases, solo a través de estos 
métodos.
*/

using System;
using UnityEngine;

[Serializable]
public class Health
{
    [SerializeField] private int value = 10;
    [SerializeField] private int maxValue = 100;

    private void OnValidate()
    {
        if (maxValue < 1) maxValue = 1;
        if (value < 0) value = 0;
        if (value > maxValue) value = maxValue;
    }

    public void TakeDamage(int damage)
    {
        if (damage <= 0)
        {
            Debug.LogWarning("TakeDamage: el daño debe ser un valor positivo.");
            return;
        }

        value -= damage;
        if (value < 0) value = 0;

        Debug.Log("Daño: " + damage + " Vida restante: " + value);
    }

    public void Heal(int heal)
    {
        if (heal <= 0)
        {
            Debug.LogWarning("Heal: la curación debe ser un valor positivo.");
            return;
        }

        value += heal;
        if (value > maxValue) value = maxValue;

        Debug.Log($"Te has curado {heal}. Ahora tienes {value} puntos de vida");
    }

    public int GetLife()
    {
        return value;
    }
}