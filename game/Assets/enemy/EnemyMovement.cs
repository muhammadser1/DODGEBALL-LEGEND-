using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 1f; // The speed at which the enemy moves
    public float detectionRadius = 5f; // The radius around the enemy in which the player can be detected
    private Vector3 currentDirection; // The current direction in which the enemy is moving
    private Transform playerTransform; // The transform of the player object

    void Start()
    {
        // Find the transform of the player object
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        // Calculate the distance between the enemy and the player
        float distance = Vector3.Distance(transform.position, playerTransform.position);

        // If the player is close enough, move the enemy towards the player
        if (distance <= detectionRadius)
        {
            currentDirection = (playerTransform.position - transform.position).normalized;
            transform.Translate(currentDirection * speed * Time.deltaTime);
        }
    }
}
