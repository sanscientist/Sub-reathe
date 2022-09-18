using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject reward2;
    public float respawnTime = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(rewardWave2());
    }

    private void OnCollision(Collision col)
    {
        if (col.gameObject.name == "Diamond")
        {
            Destroy(col.gameObject);
        }
    }

    private void spawnReward2()
    {
        GameObject b = Instantiate(reward2) as GameObject; //clone
        b.transform.position = new Vector2(12f, Random.Range(-3.2f, 3.2f));
    }

    IEnumerator rewardWave2()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnReward2();
        }

    }

 

}
