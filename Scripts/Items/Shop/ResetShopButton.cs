using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetShopButton : MonoBehaviour
{
    public void ResetShop()
    {
        GetComponentInParent<ShopManager>().ResetShop();
    }
}
