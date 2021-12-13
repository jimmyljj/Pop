using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform target;
    public GameObject theEnemy;
    public int xPos;
    public int zPos;
    public int enemyCount;
    public int maxEnemies;

    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        while (enemyCount < maxEnemies)
        {
            xPos = Random.Range(1, 15);
            zPos = Random.Range(1, 10);
            GameObject newEnemy = Instantiate(theEnemy, new Vector3(xPos, 2.55f, zPos), Quaternion.identity);

            EnemySlime slime = newEnemy.GetComponent<EnemySlime>();
            slime.target = target;
            yield return new WaitForSeconds(0.1f);
            enemyCount ++;
        }
    }

}
