using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedPacket : MonoBehaviour
{
    public SeedTypes typeOfSeed;

    public void PurchaseSeed(int cost)
    {
        if (FindObjectOfType<SeedPicker>() != null)
        {
            FindObjectOfType<SeedPicker>().AddSeedToList(typeOfSeed);
            GameManager.currency -= cost;
            Debug.Log("Money Left: " + GameManager.currency);
            Destroy(gameObject);
        }
    }
}
