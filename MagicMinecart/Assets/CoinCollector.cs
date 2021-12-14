using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollector : MonoBehaviour
{
    [SerializeField] int coins;
    Text coinUi;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);

        GameObject[] arr = GameObject.FindGameObjectsWithTag("coinCollector");
        if (arr.Length > 1) Destroy(arr[1]);
    }

    private void Update()
    {
        coinUi = GameObject.Find("CoinText").GetComponent<Text>();
        coinUi.text = coins.ToString();
    }

    public void addCoins(int coin)
    {
        coins += coin;
    }
}
