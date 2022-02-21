using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] WateringCan wateringCan;


    public Text currencyText;
    public Text ammoText;
    public Text waterText;

    //Debug Stuff
    public Text commandingText;

    private void Awake()
    {
        //wateringCan = FindObjectOfType<WateringCan>();
    }

    private void Update()
    {
        currencyText.text = "Coins: " + GameManager.currency.ToString();

        waterText.text = "Water: " + wateringCan.ReturnWaterAmount();

        //Debug

        commandingText.text = "Command State = " + GameManager.isPlayerInCommandState.ToString();
    }

}
