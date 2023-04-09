using UnityEngine;

public class test : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float maxDistanceFromEnemy = 10f;
    public float destroyDelay = 1f;

    private Transform playerTransform;
    private Transform enemyTransform;
    private Rigidbody ballRigidbody;

    private bool hasTarget = false;

    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        enemyTransform = GameObject.FindGameObjectWithTag("Enemy").transform;
        ballRigidbody = GetComponent<Rigidbody>();

        Destroy(gameObject, 2f); // Destroy the ball after destroyDelay seconds
    }

    private void Update()
    {
        // Calculate the distance to the player
        float distanceToPlayer = Vector3.Distance(transform.position, playerTransform.position);

        // If the enemy is close to the ball and there is no target yet
        if (!hasTarget && Vector3.Distance(transform.position, enemyTransform.position) <= maxDistanceFromEnemy)
        {
            // Set the target to be the player
            hasTarget = true;
        }

        // If there is a target, move towards it
        if (hasTarget)
        {
            Vector3 targetPosition = playerTransform.position;

            Vector3 moveDirection = (targetPosition - transform.position).normalized;
            ballRigidbody.velocity = moveDirection * moveSpeed;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        // If the ball collides with the player, destroy it after the specified delay
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject, 0.01f);
        }
    }
}
