using UnityEngine;
using UnityEngine.UI;

public class EnterToClick : MonoBehaviour
{
    public Button playAgainButton;
    public Button loseAgainButton;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            if (playAgainButton.gameObject.activeInHierarchy)
            {
                playAgainButton.onClick.Invoke();
            }
            else if (loseAgainButton.gameObject.activeInHierarchy)
            {
                loseAgainButton.onClick.Invoke();
            }
        }
    }
}