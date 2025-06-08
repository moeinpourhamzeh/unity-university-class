using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class DropletBehaviour : MonoBehaviour
{

    [SerializeField] private GameObject _prefab;


    public void SpawnDroplet()
    {
        Instantiate(_prefab, new Vector3(Random.Range(-8f, 8f), 9f, 0), Quaternion.identity);
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SpawnDroplet();
            Destroy(gameObject);
        } 
        else if (other.gameObject.CompareTag("Ground"))
        {
            Debug.LogError("You Lost!");
        }
    }
}
