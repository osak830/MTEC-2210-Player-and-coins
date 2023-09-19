using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject coinPrefab;
    private float heightValue = 4;
    private float widthvalue = 8;

    public Color[] coinColors;
    // Start is called before the first frame update
    void Start()
    {
        //SpawnCoin();

        InvokeRepeating("SpawnCoin", 4, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SpawnCoin()
    {
        float randomYValue = Random.Range(-heightValue, heightValue);
        float randomXValue = Random.Range(-widthvalue, widthvalue);

        Vector3 pos = new Vector3(randomXValue, randomYValue, 0);
        GameObject coin = Instantiate(coinPrefab, pos, Quaternion.identity);

        CoinScript coinScript = coin.GetComponent<CoinScript>();

        int rndValue = Random.Range(0, 3);
        coinScript.ChangeCoinValue(rndValue);
        coinScript.ChangeCoinColor(coinColors[rndValue]);
    }
}
