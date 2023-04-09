using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class lal : MonoBehaviour
{
    int hp1 = 0;
    public Slider healthSlider;
    private int health = 100;

    void Start()
    {
        // Set the initial value of the health slider to 100
        healthSlider.value = health;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "FireBall")
        {
            StartCoroutine(ReduceHealthOverTime(1   , 0.1f));
        }
        if (other.gameObject.name == "Ball1")
        {
            health -= 10;
            healthSlider.value = health;
        }
    }

    IEnumerator ReduceHealthOverTime(int reductionPerSecond, float duration)
    {
        float elapsed = 0;
        while (elapsed < duration)
        {
            health -= reductionPerSecond;
            healthSlider.value = health;
            elapsed += Time.deltaTime;
            yield return null;
        }
    }

    void Update()
    {
        // Check if health has reached 0 and restart game if it has
        if (health <= 0)
        {
        }

        if (hp1 == 0)
        {
            if (transform.position.x >= 24 && transform.position.x <= 26)
            {
                if (transform.position.y >= 0 && transform.position.y <= 2)
                {
                    if (transform.position.z >= 19 && transform.position.z <= 21)
                    {
                        health += 10;
                        healthSlider.value = health;
                        hp1++;
                        GameObject obj = GameObject.Find("Bottle_Health");

                        if (obj != null)
                        {
                            Destroy(obj);
                        }
                    }
                }
            }
        }
    }
}
