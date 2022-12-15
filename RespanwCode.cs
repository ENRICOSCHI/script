using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespanwCode : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;

    void OnTriggerEnter2D(Collider2D collision)
    {
        player.transform.position = respawnPoint.transform.position;    
    }
}
