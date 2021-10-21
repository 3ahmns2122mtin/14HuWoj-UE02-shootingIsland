using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int minRandomX = -400;
    public int maxExclusiveRandomX = 401;
    public int minRandomY = -200;
    public int maxExclusiveRandomY = 201;

    public bool won;
    public bool lost;
    public int score;
    public float InvokeTime = 1f;
    public float InvokeRepeatRate = 2f;

    public GameObject target;
    public GameObject parentOfTargets;

    void Start()
    {
        won = false;
        lost = false;
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

        Debug.Log("sooaisbwdouv");
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
            Destroy(gameObject);
        }
    }

    public void IncrementScore()
    {
        score++;
        Debug.Log("Increment...");

        if (score > 10)
        {
            won = true;
            lost = false;
        }
        else
        {
            won = false;
            lost = true;
        }
    }
}
