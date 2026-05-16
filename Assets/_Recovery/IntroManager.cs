using UnityEngine;
using UnityEngine.Video;

public class IntroManager : MonoBehaviour
{
    public VideoPlayer video;
    public GameObject startButton;
    public GameObject introVideo;
    public GameObject diver;
    public GameObject oxygenManager;
    public GameObject compass;
    public GameObject losePanel;

    public float showButtonAfter = 5f;

    void Start()
    {
        startButton.SetActive(false);
        diver.GetComponent<DiverMovement>().enabled = false;
        oxygenManager.SetActive(false);
        compass.SetActive(false);
        losePanel.SetActive(false);
        Invoke(nameof(ShowButton), showButtonAfter);
    }

    void Update()
    {
        if (startButton.activeSelf && Input.GetKeyDown(KeyCode.Return))
        {
            StartGame();
        }
    }

    void ShowButton()
    {
        startButton.SetActive(true);
    }

    public void StartGame()
    {
        video.Stop();
        introVideo.SetActive(false);
        startButton.SetActive(false);
        diver.GetComponent<DiverMovement>().enabled = true;
        oxygenManager.SetActive(true);
        oxygenManager.GetComponent<OxygenTimer>().StartOxygen();
        compass.SetActive(true);
    }
}