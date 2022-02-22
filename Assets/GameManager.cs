using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{
    public static GameManager gm;
    public Text scoreUI;
    public GameObject liveHolder,gameOver;
    int score = 0, live = 3 ;
    private void Awake()
    {
        gm = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IncrementScore()
    {
        score++;
        scoreUI.text = score.ToString();
    }
    public void DecreaseLive()
    {
        if (live > 0)
        {
            live--;
            liveHolder.transform.GetChild(live).gameObject.SetActive(false);
        }
        if(live<=0)
            GameOver();
            
    }
    public void GameOver()
    {
        SpawnCandy.instance.StopSpawnCandy();
        GameObject.Find("Player").GetComponent<PlayerMovement>().move = false;
        gameOver.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene("GameStart");
    }
    public void BackMenu()
    {
        SceneManager.LoadScene("GameMenu");
    }
}
