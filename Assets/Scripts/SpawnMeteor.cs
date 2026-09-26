
using UnityEngine;

public class MovMeteor : MonoBehaviour
{
    public GameObject meteorPrefab;
    float spawnRate=25f;
    float rateIncremetn=1f;
    private float spawnNext = 0;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > spawnNext)
        {
            spawnNext=Time.time +60/spawnRate;
            spawnRate+=rateIncremetn;

            float random = Random.Range(-10f,10f);
            Vector3 posicionSpawn = new Vector3(random,8f,-5f);  

            GameObject meteor =Instantiate(meteorPrefab,posicionSpawn,Quaternion.identity);
                  
        }
    }
}
