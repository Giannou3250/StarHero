using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
  public GameObject enemyPrefab;
  int SpawnCase = 4; // spawncase is responsible for spawning AI in different areas of the screen
  public int j = 0; // j value is used for each spawn case
  float  enemyRate = 10; // the rate at which enemy ships will spawn
  float nextEnemy = 1;
  int timer = 10; 

  IEnumerator waiter()
{
  /*
  This waiter function will be used to increase the spawn rate incrementally over
  the course of the game. timer is set to 10 seconds as seen in the variable declarations 
  above. So every 10 seconds the enemRate will decrement meaning enemy spawns will become more
  frequent and often. 
  */
  yield return new WaitForSecondsRealtime(timer);
  enemyRate--;
  yield return new WaitForSecondsRealtime(timer);
  enemyRate--;
  yield return new WaitForSecondsRealtime(timer);
  enemyRate--;
  yield return new WaitForSecondsRealtime(timer);
  enemyRate--;
  yield return new WaitForSecondsRealtime(timer);
  enemyRate--;
  yield return new WaitForSecondsRealtime(timer);
  enemyRate--;
  yield return new WaitForSecondsRealtime(timer);
  enemyRate--;
  yield return new WaitForSecondsRealtime(timer);
  enemyRate--;
  yield return new WaitForSecondsRealtime(timer);
  enemyRate--;
  timer = timer + 20;
  yield return new WaitForSecondsRealtime(timer);
  timer = timer + 30;
  enemyRate = enemyRate - 0.5f;
  yield return new WaitForSecondsRealtime(timer);
  enemyRate = enemyRate - 0.1f;
}


    void Awake()
    {
      // run the waiter function above at the start of the game
    StartCoroutine(waiter());
  }


    // Update is called once per frame

    void Update()
    {

      if (timer == 110)
      {
        enemyRate = 1;
      }

      nextEnemy -= Time.deltaTime;
      if(nextEnemy <= 0)
      {
        nextEnemy = enemyRate;
        // 0.9999f
        enemyRate *=  0.9999f;
        SpawnCase = Random.Range(1, 4);


        // spawn case 1 will be responsible for spawning AI anywehre on the right border of the screen
        if (SpawnCase == 1)
        {
          for (int i = 0; i <= j; i ++)
          {
       Vector3 offset = new Vector3(13, Random.Range(-10, 10), 0);
        Instantiate(enemyPrefab, Camera.main.transform.position + offset, transform.rotation);
        }
        }
          // spawn case 2 will be responsible for spawning AI anywehre on the left border of the screen
        else if (SpawnCase == 2)
        {
          for (int i = 0; i <= j; i ++)
          {
        Vector3 offset = new Vector3(-13, Random.Range(-10, 10), 0);
        Instantiate(enemyPrefab, Camera.main.transform.position + offset, transform.rotation);
      }
        }
          // spawn case 3 will be responsible for spawning AI anywehre on the top border of the screen
        else if (SpawnCase == 3)
        {
          for (int i = 0; i <= j; i ++)
          {
        Vector3 offset = new Vector3(Random.Range(-8, 7), 9, 0);
        Instantiate(enemyPrefab, Camera.main.transform.position + offset, transform.rotation);
      }
        }
        else if (SpawnCase == 4)
        {
          for (int i = 0; i <= j; i ++)
          {
              // spawn case 1 will be responsible for spawning AI anywehre on the bottom border of the screen
        Vector3 offset = new Vector3(Random.Range(-8, 7), -9, 0);
        Instantiate(enemyPrefab, Camera.main.transform.position + offset, transform.rotation);
      }
        }

      }

    }

}
