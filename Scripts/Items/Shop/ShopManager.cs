using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    [SerializeField] List<GameObject> seedPackets;
    [SerializeField] Transform[] slots;


    // Start is called before the first frame update
    void Start()
    {
        ResetShop();
    }


    public void ResetShop()
    {

        foreach (SeedPacket packets in FindObjectsOfType<SeedPacket>())
        {
            Destroy(packets.gameObject);
        }

        for (int i = 0; i < slots.Length; i++)
        {
            int randomIndex = Random.Range(0, seedPackets.Count);
            Instantiate(seedPackets[randomIndex], slots[i].position, Quaternion.identity);
        }
    }
}
