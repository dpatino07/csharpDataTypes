using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_2 : MonoBehaviour
{
    public string playerName = "Player Name";
    public int playerHealth = 100;
    public float playerSpeed = 5.0f;
    public bool isDead = false;

    void Start()
    {
        Debug.Log(playerName + " " + playerHealth + " " + playerSpeed + " " + isDead);
    }
}
