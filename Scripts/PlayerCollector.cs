using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollector : MonoBehaviour, ICoinCollector
{
    private int coinCount = 0;

    public void CollectCoin()
    {
        coinCount++;
        Debug.Log("Monedas recogidas: " + coinCount);
    }
}
