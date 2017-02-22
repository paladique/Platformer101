﻿using UnityEngine;
using System.Collections;

public class CoinSpawn : MonoBehaviour
{
    public Transform[] coinSpawns;
    public GameObject coin;

    // Use this for initialization
    void Start()
    {
        Spawn();
    }

    void Spawn()
    {
        for (int i = 0; i < coinSpawns.Length; i++)
        {
            int coinFlip = Random.Range(0, 3);
            if (coinFlip > 0)
                Instantiate(coin, coinSpawns[i].position, Quaternion.identity);
        }
    }

}