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

    public GameObject wonObject;
    public GameObject backgroundObject;

    public GameObject hitSound;
    //public GameObject wonSound;
    private const int maxHit = 10;

    void Start()
    {
        Debug.Log("Game Manager alive");
        won = false;
        textCounter = targetCounter.GetComponent<Text>();
        if (textCounter == null)
        {
            Debug.Log("TextCounterIsNull");
        }

        else
        {
            Debug.Log("TextCounterIsNotNull" + textCounter.name);
        }

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
            hitSound.GetComponent<AudioSource>().Play();
        }
    }

    public void IncrementScore()
    {
        score++;
        if (textCounter != null)
        {
            Debug.Log("Score" + score);
            textCounter.text = score.ToString();
            Debug.Log("textCouter" + textCounter);
        }

        else
        {
            Debug.Log("TextCounterIsNull");
        }

        if (score >= maxHit)
        {
            won = true;
            //wonSound.GetComponent<AudioSource>().Play();
        }
    }
}