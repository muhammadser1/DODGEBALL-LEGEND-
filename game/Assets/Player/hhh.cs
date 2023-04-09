using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class hhh : MonoBehaviour
{
    public Slider healthBar;
    public float maxHealth = 100f;
    private float currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.maxValue = maxHealth;
        healthBar.value = currentHealth;
    }

    void Update()
    {
        // Update the health bar
        healthBar.value = currentHealth;

        // Update the health bar position
        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position + new Vector3(0, 1.5f, 0));
        healthBar.GetComponent<RectTransform>().anchoredPosition = new Vector2(screenPos.x, screenPos.y);
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        // Check if the enemy is defeated
        if (currentHealth <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        // Destroy the enemy object
        Destroy(gameObject);
    }
}
