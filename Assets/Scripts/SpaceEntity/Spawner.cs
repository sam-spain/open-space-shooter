using UnityEngine;

namespace SpaceObjects
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField]
        private GameObject spawnPrefab;

        [SerializeField]
        private SpawnPoint[] spawnPoints;

        [SerializeField]
        private float spawnRate = 1F;
        private float spawnCounter = 0F;
        private void Start()
        {
            spawnPoints = GetComponentsInChildren<SpawnPoint>();
        }

        private void Update()
        {
            spawnCounter += Time.deltaTime;
            if (spawnCounter > spawnRate)
            {
                Spawn();
                spawnCounter = 0;
            }
        }

        internal void Spawn()
        {
            Instantiate(spawnPrefab,
                spawnPoints[Random.Range(0, spawnPoints.Length)].transform.position,
                Quaternion.identity);
        }
    }
}