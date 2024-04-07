using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrefabSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;

    [SerializeField]
    private Vector3 spawnLocation;

    [SerializeField]
    private bool spawnOnStart;

    [Header("UI Config")]
    [SerializeField]
    private Button SpawnButton;

    private void Start()
    {
        if(spawnOnStart)
        {
            Instantiate(prefab, spawnLocation, Quaternion.identity);
        }
    }
}
