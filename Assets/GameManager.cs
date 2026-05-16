using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int totalItems = 3;
    private int collectedItems = 0;

    public GameObject discoveryMessage;
    public GameObject pirateCharacter;
    public TextMeshProUGUI itemsCountText;

    void Awake()
    {
        Instance = this;
        discoveryMessage.SetActive(false);
        if (pirateCharacter != null)
            pirateCharacter.SetActive(false);

        itemsCountText.text = "<color=#FFD800>[ Collected Items: 0/" + totalItems + " ]</color>";
    }

    public void ItemCollected()
    {
        collectedItems++;
        itemsCountText.text = "<color=#FFD800>[ Collected Items: " + collectedItems + "/" + totalItems + " ]</color>";

        if (collectedItems >= totalItems)
        {
            ShowDiscovery();
        }
    }

    void ShowDiscovery()
    {
        discoveryMessage.SetActive(true);

        GameObject player = GameObject.FindWithTag("Player");

        if (player != null)
        {
            Vector3 spawnPos = player.transform.position
                     + player.transform.forward * 2f
                     - player.transform.right * 1.5f;
            spawnPos.y = player.transform.position.y;
            pirateCharacter.transform.position = spawnPos;
            pirateCharacter.transform.rotation = Quaternion.Euler(0, player.transform.eulerAngles.y + 180f, 0);

            DiverMovement diver = player.GetComponent<DiverMovement>();
            if (diver != null) diver.enabled = false;
        }

        pirateCharacter.SetActive(true);

        OxygenTimer oxygen = FindObjectOfType<OxygenTimer>();
        if (oxygen != null) oxygen.enabled = false;
    }
}