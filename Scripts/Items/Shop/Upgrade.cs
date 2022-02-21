using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade : MonoBehaviour
{
    public void PurchaseUpgrade(int cost)
    {
        Debug.Log("Purchased Upgrade!");
        GameManager.currency -= cost;
        Debug.Log("Money Left: " + GameManager.currency);
        Destroy(gameObject);
    }
}
