using UnityEngine;

public class Player : MonoBehaviour
{
    private Health Health = new();
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        Health.TakeDamage(damage);       
    }





}
