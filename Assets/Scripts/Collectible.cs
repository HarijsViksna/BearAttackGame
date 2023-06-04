using UnityEngine;
using System.Collections;

public class Collectible : MonoBehaviour
{
    public static event System.Action OnCollected;
    public static int total;

    bool isBeingCollected = false;
    float collectionTime = 1f;
    float collectionTimer = 0f;

    void Awake()
    {
        total++;
    }

    void Update()
    {
        if (isBeingCollected)
        {
            collectionTimer += Time.deltaTime;

            if (collectionTimer >= collectionTime)
            {
                OnCollected?.Invoke();
                Destroy(gameObject);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isBeingCollected = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isBeingCollected = false;
            collectionTimer = 0f;
        }
    }
}
