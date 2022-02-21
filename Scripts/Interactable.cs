using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public void Interact()
    {
        if (this.GetComponent<PlantingGround>() != null)
        {
            this.GetComponent<PlantingGround>().Interaction();
            return;
        }

        if (this.GetComponent<Well>() != null)
        {
            this.GetComponent<Well>().RefillWateringCan();
            return;
        }

        if (this.GetComponent<Item>() != null)
        {
            this.GetComponent<Item>().Purchased();
            return;
        }

        if (this.GetComponent<ResetShopButton>() != null)
        {
            this.GetComponent<ResetShopButton>().ResetShop();
        }
    }
}
