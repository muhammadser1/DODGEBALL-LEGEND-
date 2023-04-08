using UnityEngine;

public class BallController : MonoBehaviour
{
    private float originalY; // store the original y position of the ball

    void Start()
    {
        originalY = transform.position.y;
    }

    void Update()
    {
        if (transform.position.y > 4f)
        {
            // Move the ball down to the y = 2 position
            transform.position = new Vector3(transform.position.x, 2f, transform.position.z);
        }
        if (transform.position.y <0.5f)
        {
            // Move the ball down to the y = 2 position
            transform.position = new Vector3(transform.position.x, 1f, transform.position.z);
        }
        else if (transform.position.y < originalY)
        {
            // Reset the ball to its original y position if it falls below it
            transform.position = new Vector3(transform.position.x, originalY, transform.position.z);
        }
    }
}
