using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seeds : MonoBehaviour
{
    public InputManager inputManager;

    private SeedPicker seedPicker;


    void Start()
    {
        seedPicker = GetComponentInChildren<SeedPicker>();

        GetComponent<MeshRenderer>().material.color = Color.green;

        inputManager = InputManager.Instance;
    }

    void Update()
    {

    }

    public SeedTypes ReturnCurrentSeed()
    {
        return seedPicker.ReturnCurrentSeed();
    }
}
