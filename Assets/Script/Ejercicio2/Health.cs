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
using Unity.VisualScripting;
using UnityEngine;


[Serializable]
public class Health
{
    [SerializeField] private int value = 10;

    public void TakeDamage(int damage) //imcompleto
    {
        value -= damage;
        if (value < 0)
            value = 0;

        Debug.Log("Daño: " + damage + " Vida restante: " + value);
    }

    public void Heal(int _heal)
    {
        value += _heal;
        Debug.Log($"Te has curado {_heal}. Ahora tienes {value} puntos de vida");
    }

    public int GetLife()
    {
        Debug.Log("Current Life:" + value);
        return value;
    }

}