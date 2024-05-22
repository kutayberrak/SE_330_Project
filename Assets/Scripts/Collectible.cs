using UnityEngine;
using TMPro;

public class Collectible : MonoBehaviour
{
    private int boltCounter = 0;
    private int coinCounter = 0;
    public TextMeshProUGUI boltCounterText;
    public TextMeshProUGUI coinCounterText;

    private float lastCoinPositionX;
    float currentPositionX;
    private float coinDistanceThreshold = 10f;
    float distanceTraveled;


    private void Start()
    {
        lastCoinPositionX = transform.position.x;
    }
    private void Update()
    {
        currentPositionX = transform.position.x;
        distanceTraveled = Mathf.Abs(currentPositionX - lastCoinPositionX);

        if (distanceTraveled >= coinDistanceThreshold)
        {
            GainCoinAtPositionX();
            lastCoinPositionX = currentPositionX;
        }

        boltCounterText.text = boltCounter.ToString();
        coinCounterText.text = coinCounter.ToString();

    }

    public void IncreaseBoltCount()
    {
        boltCounter++;
    }
    public void GainCoinAtPositionX()
    {
        coinCounter++;
    }

    public void setCoin(int coin)  //For debug
    {
        coinCounter = coin;
    }

    public int getCoin()
    {
        return coinCounter;
    }

    public void setBolt(int bolt)  //For debug
    {
        boltCounter = bolt;
    }

    public int getBolt()
    {
        return boltCounter;
    }
}
