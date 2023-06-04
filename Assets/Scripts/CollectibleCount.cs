using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CollectibleCount : MonoBehaviour
{
    TMPro.TMP_Text text;
    int count;

    void Awake()
    {
        text = GetComponent<TMPro.TMP_Text>();
    }

    void Start()
    {
        count = 0;
        UpdateCount();
    }

    void OnEnable()
    {
        Collectible.OnCollected += OnCollectibleCollected;
    }

    void OnDisable()
    {
        Collectible.OnCollected -= OnCollectibleCollected;
    }

    void OnCollectibleCollected()
    {
        count++;
        UpdateCount();
    }

    void UpdateCount()
    {
        text.text = $"{count} / {Collectible.total}";

        if (count == Collectible.total)
        {
            SceneManager.LoadScene("Victory");
        }
    }
}
