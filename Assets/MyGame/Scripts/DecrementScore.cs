using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecrementScore : MonoBehaviour
{
    public GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    private void OnMouseDown()
    {
        gameManager.DecrementScore();
    }
}
