using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlantingGroundUI : MonoBehaviour
{
    [SerializeField] Text currentPlantText;
    private PlantingGround ground;


    void Start()
    {
        currentPlantText = GetComponentInChildren<Text>();
        ground = GetComponent<PlantingGround>();

        //ground.GetCurrentSeed();
        Debug.Log(currentPlantText.gameObject);
    }

    void Update()
    {
        if (ground.GetCurrentSeed() != null)
        {
            currentPlantText.text = ground.GetCurrentSeed().name;
        }
        else
        {
            currentPlantText.text = null;
        }
    }
}
