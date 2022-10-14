using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;

public class BuyNoAd : MonoBehaviour
{
    public GameObject BuyButton;
    public void OnPurchaseComplete(Product product)
    {
        



        if (product.definition.id == "no_ads")
        {
            Game._isAd = false;
            Debug.Log("Complete buy");
        }
        // else if (product.definition.id == "backs_25000") _backs += 25000;
        //  else if (product.definition.id == "backs_500000") _backs += 500000;

    }

    public void OnPurchaseFailure(Product product, PurchaseFailureReason reason)
    {
        Debug.Log("Purchase of product " + product.definition.id + " failed because " + reason);
    }

    private void FixedUpdate()
    {
        if(Game._isAd == false)
        {
            BuyButton.SetActive(false);
        }
        else
        {
            BuyButton.SetActive(true);
        }
    }
}
