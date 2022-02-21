using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeedPicker : MonoBehaviour
{
    public List<SeedTypes> seedList;

    //public SeedTypes onionKnightSeed;
    //public SeedTypes dragonFruitSeed;

    public SeedTypes currentSeed;


    [SerializeField] Text currentSeedText;

    private InputManager inputManager;

    void Start()
    {
        inputManager = InputManager.Instance;
        //seedList.Add(onionKnightSeed);
        //seedList.Add(dragonFruitSeed);00

        if (seedList != null)
        {
            currentSeed = seedList[0];
        }
    }

    void Update()
    {
        SwitchSeeds();

        if (currentSeedText != null)
        {
            currentSeedText.text = currentSeed.ToString();
        }

        
        //if (inputManager.PlayerJumpedThisFrame())
        //{
        //    Debug.Log(currentSeed);
        //}
    }

    void SwitchSeeds()
    {
        if (inputManager.SwitchSeedsToTheLeft())
        {
            for (int i = 0; i < seedList.Count; i++)
            {
                Debug.Log("Seed in List: " + seedList[i] + "at this index: " + i);
                if (currentSeed == seedList[i])
                {
                    Debug.Log("Current Seed Should Be the Same: " + currentSeed + "As This: " + seedList[i]);
                    if (seedList[i--] != null)
                    {
                        currentSeed = seedList[i];
                        Debug.Log("Current Seed Is Now: " + currentSeed + "And Seed Index Is Now: " + seedList[i]);
                        return;
                    }
                }
                else if (currentSeed == null)
                {
                    currentSeed = seedList[0];
                }
            }
        }

        if (inputManager.SwitchSeedsToTheRight())
        {
            for (int i = 0; i < seedList.Count; i++)
            {
                //Debug.Log("Seed in List: " + seedList[i] + "at this index: " + i);
                if (currentSeed == seedList[i])
                {
                    Debug.Log("Current Seed Should Be the Same: " + currentSeed + "As This: " + seedList[i]);
                    if (seedList[i++] != null)
                    {
                        currentSeed = seedList[i];
                        Debug.Log("Current Seed Is Now: " + currentSeed + "And Seed Index Is Now: " + seedList[i]);
                        return;
                    }
                }
                else if (currentSeed == null)
                {
                    currentSeed = seedList[0];
                }
            }
        }

        //First Code

        //if (inputManager.SwitchSeedsToTheLeft())
        //{
        //    for (int i = 0; i < seedList.Count; i++)
        //    {
        //        if (currentSeed = seedList[i])
        //        {
        //            if (i-- < 0)
        //            {
        //                Debug.Log("Index too low");
        //            }
        //            else
        //            {
        //                currentSeed = seedList[i--];
        //                Debug.Log("Current Seed: " + currentSeed);
        //            }
        //        }
        //    }
        //}

        //if (inputManager.SwitchSeedsToTheRight())
        //{
        //    for (int i = 0; i < seedList.Count; i++)
        //    {
        //        if (currentSeed = seedList[i])
        //        {
        //            if (i++ > seedList.Count) 
        //            {
        //                Debug.Log("Index too high");
        //            }
        //            else
        //            {
        //                currentSeed = seedList[i++];
        //                Debug.Log("Current Seed: " + currentSeed);
        //            }
        //        }
        //    }
        //}
    }

    public void AddSeedToList(SeedTypes typeOfSeed)
    {
        for (int i = 0; i < seedList.Count; i++)
        {
            if (seedList[i] == typeOfSeed)
            {
                return;
            }
        }
        seedList.Add(typeOfSeed);
        Debug.Log("ADDED: " + typeOfSeed);
    }


    public SeedTypes ReturnCurrentSeed()
    {
        return currentSeed;
    }
}
