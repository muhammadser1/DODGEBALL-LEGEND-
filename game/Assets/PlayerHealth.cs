using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
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
        if (other.gameObject.name == "Ball")
        {
            health -= 10;
            healthSlider.value = health;
        }
    }
    void Update()
    {
        // Check for jump input and decrease health by 10
        if (Input.GetKeyDown(KeyCode.Space))
        {
            health -= 10;
            healthSlider.value = health;
        }

        // Check if health has reached 0 and restart game if it has
        if (health <= 0)
        {
            // Restart the game (replace this with your own restart logic)
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        }
        if(hp1==0)
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
