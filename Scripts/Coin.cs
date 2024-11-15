using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D other)
    {
        ICoinCollector collector = other.GetComponent<ICoinCollector>();
        if (collector != null)
        {
            collector.CollectCoin();
            Destroy(gameObject);
        }
    }
}