using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : Enemy
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player.TakeDamage();
        }

    }
}