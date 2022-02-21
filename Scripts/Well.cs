using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Well : MonoBehaviour
{
    //Future Notes: make watering can refill based on how much water is left in the well


    public int totalWaterAmount = 5;
    public int currentWaterAmount = 5;

    private void Start()
    {
        currentWaterAmount = totalWaterAmount;
    }

    public void RefillWateringCan()
    {
        if (currentWaterAmount > 0)
        {
            if (HeldItem.currentItem.GetComponent<WateringCan>() != null)
            {
                int amountToRefill = HeldItem.currentItem.GetComponent<WateringCan>().CheckWaterAmountMissing();

                if (amountToRefill > currentWaterAmount)
                {
                    Debug.Log("Well Needs To Be Refilled: " + currentWaterAmount + " / " + totalWaterAmount);
                }
                else
                {
                    HeldItem.currentItem.GetComponent<WateringCan>().RefillWater(amountToRefill);
                    //currentWaterAmount -= amountToRefill;
                }
            }
        }
    }


    public void RefillWell()
    {
        currentWaterAmount = totalWaterAmount;
        Debug.Log("Well Refilled: " + currentWaterAmount + " / " + totalWaterAmount);
    }
}
