using UnityEngine;

public class PirateAppear : MonoBehaviour
{
    public GameObject pirate;        // اسحب Pirate_Full هنا
    public int totalPieces = 4;      // عدد القطع المطلوبة
    private int collectedPieces = 0;

    public void PieceCollected()
    {
        collectedPieces++;
        if (collectedPieces >= totalPieces)
        {
            pirate.SetActive(true);  // يظهر القرصان
        }
    }
}