using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    [SerializeField] LayerMask playerLayer;

    CoinCollector coinCollector;

    private void Start()
    {
        if (GameObject.Find("CoinController") != null) coinCollector = GameObject.Find("CoinController").GetComponent<CoinCollector>();
    }
    private void Update()
    {
        if (Physics2D.OverlapCircle(transform.position, 0.3f, playerLayer))
        {
            coinCollector.addCoins(1);
            Destroy(gameObject);
        }
    }
}
