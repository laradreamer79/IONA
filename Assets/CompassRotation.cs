using UnityEngine;

public class CompassRotation : MonoBehaviour
{
    public Transform player;

    void Update()
    {
        transform.rotation = Quaternion.Euler(0, 0, -player.eulerAngles.y);
    }
}