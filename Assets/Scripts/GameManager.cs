using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject obstacle;
    public Transform spawnPoint;
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        GameStart();
    }

    IEnumerator SpawnObstacle()
    {
        while (true)
        {
            float waitTime = Random.Range(0.5f, 2f);
            yield return new WaitForSeconds(waitTime);
            Instantiate(obstacle, spawnPoint.position, Quaternion.identity);
        }
    }

    public void GameStart()
    {
        StartCoroutine(SpawnObstacle());
    }
}
