using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployEnemies : MonoBehaviour
{
    public GameObject enemy1;
    
    public float respawnTime = 3.0f;
    

    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(enemyWave1());
        
    }
    private void spawnEnemy1()
    {
        GameObject a = Instantiate(enemy1) as GameObject; //clone
        a.transform.position = new Vector2(12f, Random.Range(-3.2f, 3.2f));
    }

   

    // Update is called once per frame
    IEnumerator enemyWave1()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy1();
        }
        
    }

    

}
