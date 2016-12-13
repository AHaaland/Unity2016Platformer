using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class GM : MonoBehaviour {
    //Values for game
    public int coins = 0;
    public int lives = 3;
    public int coinNum;
	public int healthMax = 3;
	private int health;
	private bool isPaused = false;
    public GameObject outSign;
    public GameObject winSign;
    public GameObject pauseSign;
    //Text components to update values of the UI
    public Text coinsText;
    public Text livesText;
	public Text healthText;
    // Use this for initialization
    void Start () {
		health = healthMax;
        coinsText.text = coins.ToString();
        livesText.text = lives.ToString();
        coinNum = FindObjectsOfType<Coin>().Length;
		healthText.text = health.ToString ();
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.P)) {
			isPaused = !isPaused;
            pauseSign.SetActive(isPaused);
		}
		Time.timeScale = isPaused ? 0 : 1;
	}
    public void CoinCollection(int worth)
    {
        coins+=worth;
        coinsText.text = coins.ToString();
        coinNum--;

    }
	public void winner()
	{
		winSign.SetActive(true);
	}
    public void potionTrigger()
    {
        health = healthMax;
        healthText.text = health.ToString();
    }
    public void LifeLost()
    {
		if (health <= 0) {
			lives--;
			health = healthMax;
			livesText.text = lives.ToString ();
			healthText.text = health.ToString ();
			if (lives == 0) {
				outSign.SetActive (true);
			}
		} 
		else {
			health--;
			healthText.text = health.ToString ();
		}
    }
}
