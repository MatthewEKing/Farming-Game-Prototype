using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeldItem : MonoBehaviour
{
    [SerializeField] GameObject[] items;

    public static GameObject currentItem;

    private InputManager inputManager;

    void Start()
    {
        inputManager = InputManager.Instance;
    }


    void Update()
    {
        SwitchCurrentItems();
    }

    private void SwitchCurrentItems()
    {
        //Material material = GetComponent<MeshRenderer>().material;

        if (inputManager.SwitchToTrowel())
        {
            currentItem = items[0];
            currentItem.SetActive(true);
            currentItem.GetComponent<MeshRenderer>().material.color = Color.grey;
            DisableOtherItems(); 
            //Debug.Log("Switched to Trowel: " + currentItem);
        }

        if (inputManager.SwitchToSeeds())
        {
            currentItem = items[1];
            currentItem.SetActive(true);
            DisableOtherItems();
            //Debug.Log("Switched To Seeds: " + currentItem);
        }

        if (inputManager.SwitchToWateringCan())
        {
            currentItem = items[2];
            currentItem.SetActive(true);
            currentItem.GetComponent<MeshRenderer>().material.color = Color.blue;
            DisableOtherItems();
            //Debug.Log("Switched To Watering Can: " + currentItem);
        }

        if (inputManager.SwitchToCannon())
        {
            if (GameManager.cabbageCannon)
            {
                currentItem = items[3];
                currentItem.SetActive(true);
                DisableOtherItems();
            }
            else
            {
                return;
            }
        }
    }

    private void DisableOtherItems()
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] != currentItem)
            {
                items[i].SetActive(false);
            }
        }
    }
}
