using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public int health;
    private int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = health;
    }

    void Update()
    {
        if(currentHealth <= 0)
        {
            Destroy(gameObject);

        }
    }

    public void damageEnemy(int damage)
    {
        currentHealth -= damage;

       

    }
}
