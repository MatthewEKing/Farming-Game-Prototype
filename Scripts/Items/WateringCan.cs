using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WateringCan : MonoBehaviour
{
    int maxWaterAmount = 5;
    int waterAmount = 5;

    void Start()
    {
        waterAmount = maxWaterAmount;
    }

    public void RefillWater(int amount)
    {
        if (waterAmount + amount <= maxWaterAmount)
        {
            waterAmount += amount;
        }

        Debug.Log("Watering Can Refilled: " + waterAmount + " / " + maxWaterAmount);
        Debug.Log("This Much Was Refilled: " + amount);

    }

    public void UseWater()
    {
        waterAmount--;
        Debug.Log("Current Water Amount: " + waterAmount + " / " + maxWaterAmount);
    }

    public int CheckWaterAmountMissing()
    {
        int amountMissing = maxWaterAmount - waterAmount;
        return amountMissing;
    }

    public bool CheckIfEmpty()
    {
        if (waterAmount > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public int ReturnWaterAmount()
    {
        return waterAmount;
    }
}
