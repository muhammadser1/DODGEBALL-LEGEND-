using UnityEngine;
using UnityEngine.UI;

public class ss : MonoBehaviour
{
    public GameObject text;
    public Text pickupText;

    private void Start()
    {
        text.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            text.SetActive(true);
        }
    }
}
