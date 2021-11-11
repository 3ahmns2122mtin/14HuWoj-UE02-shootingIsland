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

    void Start()
    {
        won = false;
        textCounter = targetCounter.GetComponent<Text>();
        InvokeRepeating("Spawn", InvokeTime, InvokeRepeatRate);
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
        }

        else
        {
            Debug.Log(won);
        }

        if (Input.GetMouseButtonDown(0))
        {

        }
    }

    public void IncrementScore()
    {
        score++;
        textCounter.text = score.ToString();

        if (score >= 10)
        {
            won = true;
        }
    }
}