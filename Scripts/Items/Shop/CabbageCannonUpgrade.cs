using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabbageCannonUpgrade : MonoBehaviour
{

    public void Purchased(int itemCost)
    {
        GameManager.currency -= itemCost;
        GameManager.cabbageCannon = true;
        Destroy(this.gameObject);
    }


}
