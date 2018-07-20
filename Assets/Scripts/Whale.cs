using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Whale : MonoBehaviour {

    int lifecount = 3;
    public GameObject deathMenu, deadLifeIcon, lifeIcon1, lifeIcon2, lifeIcon3;
    private GameSettings gameSettings;


    void Start()
    {
        gameSettings = GameObject.FindGameObjectWithTag("GameSettings").GetComponent<GameSettings>();
        deadLifeIcon = GameObject.FindGameObjectWithTag("DeadLifeIcon");
        lifeIcon1 = GameObject.FindGameObjectWithTag("LifeIcon1");
        lifeIcon2 = GameObject.FindGameObjectWithTag("LifeIcon2");
        lifeIcon3 = GameObject.FindGameObjectWithTag("LifeIcon3");
    }

    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D coll)
        {
            lifecount = lifecount -1;

            if (lifecount == 0)
            {
                Time.timeScale = 0f;
                deathMenu.SetActive(true);
            } else if (lifecount == 1)
            {
                lifeIcon2.transform.Find().GetComponent<Image>().sprite = gameSettings.deadLifeIcon;
            }
            else if (lifecount == 2)
            {
                lifeIcon3.transform.Find().GetComponent<Image>().sprite = gameSettings.deadLifeIcon;
            }
        }
    }
