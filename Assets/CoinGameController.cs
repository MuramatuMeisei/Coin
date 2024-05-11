using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinGameController : MonoBehaviour
{
    public GameObject coinPrefab;
    public Text myCoins;
    public int coinCount = 10;
    public Text textGameOver;

    private void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            GenerateCoins();
        }

        myCoins.text = "My Coin:" + coinCount;

        textGameOver.enabled = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(coinCount > 0)
            {
                GenerateCoins();
                coinCount -= 1;
            }

            if(coinCount == 0)
            {
                textGameOver.enabled = true;
            }

            myCoins.text = "My Coin:" + coinCount;
        }
    }

    public void GenerateCoins()
    {
        float x = Random.Range(-9.93f, -3.98f);
        float z = Random.Range(33.3f, 29.84f);
        Vector3 coinPosition = new Vector3(x, 3.95f, z);
        Instantiate(coinPrefab, coinPosition, Quaternion.identity);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
            coinCount += 1;
        }
    }
}
