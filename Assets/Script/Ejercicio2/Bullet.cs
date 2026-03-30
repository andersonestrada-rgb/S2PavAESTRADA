using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private int damage = 5;
    [SerializeField] private float lifeTime = 5f;

    // Inicializa parámetros desde Weapon al instanciar la bala.
    public void Init(int damageValue, float speedValue)
    {
        damage = damageValue;
        speed = speedValue;
    }

    void Start()
    {       
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime, Space.Self);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Enemy"))
        {            
            Enemy enemy = collider.GetComponent<Enemy>();

            // 3. Verificamos que el componente realmente exista para evitar errores (NullReferenceException).
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
                Destroy(gameObject);
            }
        }
    }  
}