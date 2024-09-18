using UnityEngine;

public class ObstacleFactory
{
    private static ObstacleFactory _instance;
    public static ObstacleFactory Instance => _instance ??= new ObstacleFactory();

    public void CreateObstacle(Vector3 spawnPosition)
    {
        GameObject obstaclePrefab = Resources.Load<GameObject>("ObstaclePrefab");
        if (obstaclePrefab == null)
        {
            Debug.LogError("ObstaclePrefab is not found in Resources folder!");
            return;
        }
        GameObject obstacle = Object.Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
    }

}
