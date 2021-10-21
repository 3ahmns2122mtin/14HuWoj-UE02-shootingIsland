using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
     [SerializeField] private int secondsToDestroy = 1;

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
