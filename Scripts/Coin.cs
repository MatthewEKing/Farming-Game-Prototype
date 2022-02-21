using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int amount = 10;


    private void Update()
    {
        //Rotate
        transform.Rotate(Time.deltaTime * Vector3.up * 100, Space.World);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameManager.currency += amount;
            Destroy(gameObject);
        }
    }
}
