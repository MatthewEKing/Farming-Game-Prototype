using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenWateringCanUpgrade : MonoBehaviour
{
    public void Purchased(int itemCost)
    {
        GameManager.goldenWateringCan = true;
        GameManager.currency -= itemCost;
        Destroy(this.gameObject);
    }
}
