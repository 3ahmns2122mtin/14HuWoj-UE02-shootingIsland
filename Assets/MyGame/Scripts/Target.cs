using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private float secondsToDestroy = 3f;

    public GameManager gameManager;

    void Start()
    {
        Destroy(gameObject, secondsToDestroy);
    }

    private void OnMouseDown()
    {
        gameManager.IncrementScore();
        Destroy(gameObject);
    }

    void Update()
    {
        
    }
}
