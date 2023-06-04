/*using UnityEngine;
using System.Collections;

public class CollectibleCount : MonoBehaviour
{
    TMPro.TMP_Text text;
    int count;

    void Awake()
    {
        text = GetComponent<TMPro.TMP_Text>();
    }

    void Start() => UpdateCount();

    void OnEnable() => Collectible.OnCollected += OnCollectibleCollected;
    void OnDisable() => Collectible.OnCollected -= OnCollectibleCollected;

    void OnCollectibleCollected()
    {
        StartCoroutine(CollectibleCollectedCoroutine());
    }

    IEnumerator CollectibleCollectedCoroutine()
    {
        // Wait for 1 second
        yield return new WaitForSeconds(1f);

        count++;
        UpdateCount();
    }

    void UpdateCount()
    {
        text.text = $"{count} / {Collectible.total}";
    }
}
*/