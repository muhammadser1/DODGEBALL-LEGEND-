using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
public class lal : MonoBehaviour
{
    public Slider healthSlider;
    private int health = 100;

    void Start()
    {
        // Set the initial value of the health slider to 100
        healthSlider.value = health;
    }

    void Update()
    {


        // Check if player has hit a ball and decrease health by 10
        // Replace "Ball" with the name of the object that represents the ball in your scene
        // You can also use a tag instead of the object name
        // For example, if you set the ball's tag to "Ball", you can use "other.gameObject.CompareTag("Ball")" instead of "other.gameObject.name == "Ball""
       

        if (health <= 0)
        {
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Ball1")
        {
            health -= 10;
            healthSlider.value = health;
        }
    }
}
