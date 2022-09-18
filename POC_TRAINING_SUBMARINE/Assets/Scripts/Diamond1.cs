using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond1 : MonoBehaviour
{

    public GameObject reward1;
    public float respawnTime = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(rewardWave1());
    }

    private void spawnReward1()
    {
        GameObject a = Instantiate(reward1) as GameObject; //clone
        a.transform.position = new Vector2(12f, Random.Range(-3.2f, 3.2f));
    }

    IEnumerator rewardWave1()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnReward1();
        }

    }


}
