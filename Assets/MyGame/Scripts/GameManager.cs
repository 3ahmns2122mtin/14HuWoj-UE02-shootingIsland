using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int minRandomX = -400;
    public int maxExclusiveRandomX = 401;
    public int minRandomY = -200;
    public int maxExclusiveRandomY = 201;

    public GameObject target;
    public GameObject parentOfTargets;

    public float InvokeTime = 1f;
    public float InvokeRepeatRate = 1f;

    public bool won;
    public int score;

    private Text textCounter;
    public GameObject targetCounter;
    private const int maxHit = 10;

    public GameObject wonObject;
    public GameObject backgroundObject;

    public GameObject hitSound;
    public GameObject wonSound;

    void Start()
    {
        won = false;

        textCounter = targetCounter.GetComponent<Text>();
        InvokeRepeating("Spawn", InvokeTime, InvokeRepeatRate);

        wonObject.SetActive(false);
        backgroundObject.SetActive(false);
    }

    // Spawn a target at a random position
    private void Spawn()
    {
        float randomX = Random.Range(minRandomX, maxExclusiveRandomX);
        float randomY = Random.Range(minRandomY, maxExclusiveRandomY);

        Vector2 random2DPosition = new Vector2(randomX, randomY);

        GameObject myTarget = Instantiate(target, parentOfTargets.transform);
        myTarget.transform.localPosition = random2DPosition;
    }

    void Update()
    {
        if (won == true)
        {
            CancelInvoke("Spawn");
            wonObject.SetActive(true);
            backgroundObject.SetActive(true);
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (score <= 9)
            {
                hitSound.GetComponent<AudioSource>().Play();
            }
        }
    }

    public void IncrementScore()
    {
        score++;

        if (textCounter != null)
        {
            textCounter.text = score.ToString();
        }

        if (score >= maxHit)
        {
            won = true;
            wonSound.GetComponent<AudioSource>().Play();
        }
    }

    public void DecrementScore()
    {
        score--;

        if (textCounter != null)
        {
            textCounter.text = score.ToString();
        }
    }
}