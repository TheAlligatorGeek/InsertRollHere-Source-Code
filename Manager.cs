using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class Manager : MonoBehaviour
{
    public GameObject menu;
    [SerializeField] Sprite[] diceimages;
    [SerializeField] SpriteRenderer spriterenderer;
    [SerializeField] SpriteRenderer secondone;
    public Sprite dice1;
    public Sprite dice2;
    public Sprite dice3;
    public Sprite dice4;
    public Sprite dice5;
    public Sprite dice6;
    public GameObject buttonroll;
    public GameObject Puck1;
    public GameObject Puck2;
    public GameObject Puck3;
    public GameObject Puck4;
    public GameObject Puck5;
    public GameObject Puck6;
    public GameObject Puck7;
    public GameObject Puck8;
    public GameObject Puck9;
    public GameObject Puck10;
    public GameObject Particle1;
    public GameObject Particle2;
    public GameObject Particle3;
    public GameObject Particle4;
    public GameObject Particle5;
    public GameObject Particle6;
    public GameObject Particle7;
    public GameObject Particle8;
    public GameObject Particle9;
    public GameObject Particle10;
    public GameObject winner;
    private bool enter = false;
    private bool enter2 = false;
    private bool enter3 = false;
    private bool enter4 = false;
    private bool enter5 = false;
    private bool enter6 = false;
    private bool enter7 = false;
    private bool enter8 = false;
    private bool enter9 = false;
    private bool enter10 = false;
    int randomNumber;
    int anotherNumber;
    int numberTotal=0;

    public void ExitGame()
    {
        Debug.Log("Test");
        Application.Quit();
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void GoBack()
    {
        SceneManager.LoadScene("Menu");
    }
    public void PauseMenu()
    {
        menu.SetActive(true);
    }
    public void UnPause()
    {
        menu?.SetActive(false);
    }
    public void roll()
    {
        randomNumber = Random.Range(1, 7);
        spriterenderer.sprite = diceimages[randomNumber - 1];
        print(randomNumber);
    }
    public void second()
    {
        anotherNumber = Random.Range(1, 7);
        secondone.sprite = diceimages[anotherNumber - 1];
        print(anotherNumber);
    }
    public void detector()
    {
        numberTotal = randomNumber + anotherNumber;
        print(numberTotal);
        if(numberTotal == 7)
        {
            buttonroll.SetActive(false);
            StartCoroutine(your_timer());
        }else if (numberTotal == 8)
        {
            enter6 = true;
            Particle6.SetActive(true);
            Puck6.SetActive(true);
        }else if (numberTotal == 9)
        {
            enter7 = true;
            Particle7.SetActive(true);
            Puck7.SetActive(true);
        }else if (numberTotal == 10)
        {
            enter8 = true;
            Particle8.SetActive(true);
            Puck8.SetActive(true);
        }else if (numberTotal == 11)
        {
            enter9 = true;
            Particle9.SetActive(true);
            Puck9.SetActive(true);
        }else if (numberTotal == 12)
        {
            enter10 = true;
            Particle10.SetActive(true);
            Puck10.SetActive(true);
        }else if (numberTotal == 2)
        {
            enter = true;
            Particle1.SetActive(true);
            Puck1.SetActive(true);
        }else if (numberTotal == 3)
        {
            enter2 = true;
            Particle2.SetActive(true);
            Puck2.SetActive(true);
        }else if (numberTotal == 4)
        {
            enter3 = true;
            Particle3.SetActive(true);
            Puck3.SetActive(true);
        }else if (numberTotal == 5)
        {
            enter4 = true;
            Particle4.SetActive(true);
            Puck4.SetActive(true);
        }else if (numberTotal == 6)
        {
            enter5 = true;
            Particle5.SetActive(true);
            Puck5.SetActive(true);
        }
    }
    public void PuckChecker()
    {
       if (enter == true)
        {
            if (enter2 == true)
            {
                if (enter3 == true)
                {
                    if (enter4 == true)
                    {
                        if (enter5 == true)
                        {
                            if (enter6 == true)
                            {
                                if (enter7 == true)
                                {
                                    if (enter8 == true)
                                    {
                                        if (enter9 == true)
                                        {
                                            if (enter10 == true)
                                            {
                                                winner.SetActive(true);
                                                StartCoroutine(timer1());
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        } 
    }
    IEnumerator your_timer()
    {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene("Game Over");
    }
    IEnumerator timer1()
    {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene("Credits");
    }
}
