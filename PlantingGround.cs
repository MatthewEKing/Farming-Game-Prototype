using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantingGround : MonoBehaviour
{

    private float growTimer = 999999f;

    [SerializeField] private SeedTypes currentSeed;
    private PlantingGroundUI groundUI;

    private bool beginTimer = false;
    private bool hasSeed = false;

    [SerializeField] private Material wateredSoil;
    private Transform spawnPoint;

    private void Start()
    {
        spawnPoint = this.gameObject.transform.GetChild(0).transform;
        groundUI = this.GetComponent<PlantingGroundUI>();
    }

    public void Interaction()
    {
        if (HeldItem.currentItem != null)
        {
            //If holding Seeds
            if (HeldItem.currentItem.GetComponent<Seeds>() != null)
            {
                if (!hasSeed)
                {
                    currentSeed = HeldItem.currentItem.GetComponent<Seeds>().ReturnCurrentSeed();

                    growTimer = currentSeed.growthTimer;
                    Debug.Log("Planted Seed: " + currentSeed);
                    hasSeed = true;
                    return;
                }
                else
                {
                    Debug.Log("Already has seed");
                    return;
                }
            }

            //If holding Watering Can
            if (HeldItem.currentItem.GetComponent<WateringCan>() != null)
            {
                if (hasSeed)
                {
                    if (HeldItem.currentItem.GetComponent<WateringCan>().CheckIfEmpty())
                    {
                        beginTimer = true;
                        HeldItem.currentItem.GetComponent<WateringCan>().UseWater();
                        Debug.Log("Watered Seed");
                    }
                }
                else
                {
                    Debug.Log("No seed to water");
                }
            }
        }
    }

    private void Update()
    {
        if (beginTimer && growTimer > 0) 
        {
            growTimer -= Time.deltaTime;
        }

        if (growTimer <= 0)
        {
            SpawnPlant(currentSeed);
            Debug.Log("Timer Finished");
            beginTimer = false;
            hasSeed = false;
            growTimer = 999999f;
        }
    }


    private void SpawnPlant(SeedTypes currSeed)
    {
        if (currSeed.spawnWhenFullyGrown != null)
        {
            Instantiate(currSeed.spawnWhenFullyGrown, spawnPoint.position, Quaternion.identity);
        }
    }


    public SeedTypes GetCurrentSeed()
    {
        if (currentSeed != null)
        {
            Debug.Log("Current Seed: " + currentSeed);
            return currentSeed;
        }
        else
        {
            Debug.Log("Current Seed: " + currentSeed);
            return null;
        }
    }
}
