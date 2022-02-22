using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCandy : MonoBehaviour
{
    [SerializeField] float maxRangeX;
    public GameObject[] candy;
    public float spawnRate;
    public static SpawnCandy instance;
    Coroutine co;
    private void Awake()
    {
        if (instance == null)
            instance = this;
     
    }
    // Start is called before the first frame update
    void Start()
    {
        StartSpawn();
    }

    void SpawnCandyy()
    {
        int rd = Random.Range(0, candy.Length);
        float rdPosition = Random.Range(-maxRangeX, maxRangeX);
        var newRd = new Vector3(rdPosition, transform.position.y, transform.position.z);
        Instantiate(candy[rd], newRd, transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnAfterTime()
    {
        yield return new WaitForSeconds(2f);
        while(true)
        {
            SpawnCandyy();
            yield return new WaitForSeconds(spawnRate);
        }
    }
    public void StartSpawn()
    {
         StartCoroutine("SpawnAfterTime");
    }
    public void StopSpawnCandy()
    {
        StopCoroutine("SpawnAfterTime");
    }
}
