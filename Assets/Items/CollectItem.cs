using UnityEngine;

public class CollectItem : MonoBehaviour
{
    private bool collected = false;

    public void OnTriggerEnter(Collider other)
    {
        if (collected) return;

        if (other.CompareTag("Player"))
        {
            collected = true;
            GameManager.Instance.ItemCollected();
            gameObject.SetActive(false);
        }
    }
}