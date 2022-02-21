using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Player Variables
    public static bool isPlayerInvincible;
    public static bool isPlayerInCommandState = false;

    public static int playerHealth = 5;


    //Shop Variables
    public static int currency = 200;


    //Shop Upgrades
    public static bool goldenWateringCan = false;
    public static bool cabbageCannon = true;
}
