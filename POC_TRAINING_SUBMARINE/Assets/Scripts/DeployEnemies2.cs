using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployEnemies2 : MonoBehaviour
{
    public GameObject enemy2;
    public float respawnTime2 = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(enemyWave2());
    }

    private void spawnEnemy2()
    {
        GameObject b = Instantiate(enemy2) as GameObject; //clone
        b.transform.position = new Vector2(12f, Random.Range(-3.2f, 3.2f));
    }

    IEnumerator enemyWave2()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime2);
            spawnEnemy2();
        }

    }
}
