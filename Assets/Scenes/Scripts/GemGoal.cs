using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemGoal : MonoBehaviour
{
    public AudioSource gemSound;
    public AudioClip gemClip;
    public ParticleSystem gemPickup;
    public Rigidbody2D rigidbody2d;
    public PlayerController player;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        player = collision.GetComponent<PlayerController>();

        if (player != null)
        {
            gemSound.PlayOneShot(gemClip);
            ParticleSystem gempickup = Instantiate(gemPickup, rigidbody2d.position + Vector2.up * 0.5f, Quaternion.identity);
            player.score += 1;

            Destroy(gameObject);
        }
    }
}
