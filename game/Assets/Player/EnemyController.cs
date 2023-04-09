using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    public int maxHealth = 20;
    public int currentHealth;
    public Slider healthBar;

    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.maxValue = maxHealth;
        healthBar.value = currentHealth;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            currentHealth -= 10; // reduce the enemy's health by 10
            healthBar.value = currentHealth; // update the health bar
            Destroy(other.gameObject); // destroy the ball object
        }
        if (other.CompareTag("Ball1"))
        {
            currentHealth -= 10; // reduce the enemy's health by 10
            healthBar.value = currentHealth; // update the health bar
            Destroy(other.gameObject); // destroy the ball object
        }
    }

    private void Update()
    {
        if (currentHealth <= 0)
        {
            // if the enemy's health is zero or below, destroy the enemy object
            Destroy(gameObject);
        }
    }
}
