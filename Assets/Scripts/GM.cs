using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class GM : MonoBehaviour {
    //Values for game
    public int coins = 0;
    public int lives = 3;
    public int coinNum;
    public GameObject outSign;
    public GameObject winSign;
    //Text components to update values of the UI
    public Text coinsText;
    public Text livesText;

    // Use this for initialization
    void Start () {
        coinsText.text = coins.ToString();
        livesText.text = lives.ToString();
        coinNum = FindObjectsOfType<Coin>().Length;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void CoinCollection(int worth)
    {
        coins+=worth;
        coinsText.text = coins.ToString();
        coinNum--;
        if(coinNum == 0)
        {
            winSign.SetActive(true);
        }
    }
    public void LifeLost()
    {
        lives--;
        livesText.text = lives.ToString();
        if (lives == 0)
        {
            outSign.SetActive(true);
        }
    }
}
