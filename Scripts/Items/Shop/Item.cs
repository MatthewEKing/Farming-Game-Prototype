using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int itemCost;

    //Look Effect
    Vector3 scaleChange = new Vector3(1.5f, 1.5f, 1.5f);
    Vector3 originalScale;


    private void Awake()
    {
        originalScale = transform.localScale;
    }

    private void Update()
    {
        //Rotate And Scale Effect
        transform.Rotate(Time.deltaTime * Vector3.up * 100, Space.World);

        if (Interacting.lookingAtObj == transform.gameObject)
        {
            transform.localScale = scaleChange;
        }
        else
        {
            transform.localScale = originalScale;
        }
    }


    public void Purchased()
    {
        if (GameManager.currency >= itemCost)
        {
            if (this.GetComponent<SeedPacket>() != null)
            {
                this.GetComponent<SeedPacket>().PurchaseSeed(itemCost);
            }

            else if (this.GetComponent<CabbageCannonUpgrade>() != null)
            {
                this.GetComponent<CabbageCannonUpgrade>().Purchased(itemCost);
            }

            else if (this.GetComponent<GoldenWateringCanUpgrade>() != null)
            {
                this.GetComponent<GoldenWateringCanUpgrade>().Purchased(itemCost);
            }

            else if (this.GetComponent<Upgrade>() != null)
            {
                this.GetComponent<Upgrade>().PurchaseUpgrade(itemCost);
            }

            else
            {
                Debug.Log("Purchase Unsuccessful");
            }
        }
        else
        {
            Debug.Log("Not Enough Money");
        }
    }
}
