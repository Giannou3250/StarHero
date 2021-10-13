using System.Collections.Generic;
using UnityEngine;

public class CollisionDamage : MonoBehaviour
{
//health value of players and enemies are set to 1
public  int Health = 1;
// explosion audio source 
public AudioSource boom;
void start()
{
// set boom to the audioSource
boom = GetComponent<AudioSource>();
}
void Update()
  {
    if (Health <= 0) // if health is 0 or less, kill the entity
    {
      //trigger die function
      Die();
    }
  }

  void OnTriggerEnter2D()
  {;
    //decrement health value to zero
    Health--;

  }
void Die()
{
  GameObject go = GameObject.Find("enemydeath");
  Instantiate(go, transform.position, Quaternion.identity);
  //destroy game objects during collision
  Destroy(gameObject);
  //audio source triggered upon any death
  boom.Play();
}
}
