using UnityEngine;
using UnityEngine.UI;

public class OxygenTimer : MonoBehaviour
{
    public Slider oxygenBar;
    public float maxTime = 120f;
    private float currentTime;
    private bool gameStarted = false;

    public GameObject outOfOxygenPanel;

    void Start()
    {
        currentTime = maxTime;
        oxygenBar.maxValue = maxTime;
        oxygenBar.value = maxTime;
        outOfOxygenPanel.SetActive(false);
    }

    void Update()
    {
        if (!gameStarted) return;

        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            oxygenBar.value = currentTime;
        }
        else
        {
            OutOfOxygen();
        }
    }

    public void StartOxygen()
    {
        oxygenBar.gameObject.SetActive(true); // إظهار الـ Bar
        gameStarted = true;
    }

    void OutOfOxygen()
    {
        outOfOxygenPanel.SetActive(true);
        GameObject.FindWithTag("Player")
            .GetComponent<DiverMovement>().enabled = false;
    }
}