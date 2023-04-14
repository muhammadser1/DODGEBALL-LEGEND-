using UnityEngine;

public class BallPickup6 : MonoBehaviour
{
    public GameObject ball;
    public Transform parent;
    public float pickupDistanceThreshold = 1f;
    public float throwForce = 20f;
    public float throwDistance = 10f;
    public Camera cameraObject; // assign this in the inspector

    private Rigidbody ballRigidbody;
    private bool isEquipped = false;

    void Start()
    {
        ballRigidbody = ball.GetComponent<Rigidbody>();
        ballRigidbody.isKinematic = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (!isEquipped)
            {
                float distance = Vector3.Distance(ball.transform.position, parent.position);
                if (distance < pickupDistanceThreshold)
                {
                    ball.transform.parent = parent;
                    ball.transform.localPosition = Vector3.zero;
                    ballRigidbody.isKinematic = true;
                    isEquipped = true;
                }
            }
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            if (isEquipped)
            {
                ball.transform.parent = null;
                ballRigidbody.isKinematic = false;
                Vector3 throwDirection = cameraObject.transform.forward;
                throwDirection.y = 0f; // set y component to 0
                throwDirection = throwDirection.normalized;
                Vector3 throwPosition = cameraObject.transform.position + throwDirection * throwDistance;
                ballRigidbody.AddForce(throwDirection * throwForce, ForceMode.Impulse);
                isEquipped = false;
            }
        }
    }
}
