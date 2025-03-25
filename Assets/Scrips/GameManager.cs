using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public Character Player;
    private GameObject[] itemPrefabs;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            LoadPrefabs();
            Initialize();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void LoadPrefabs()
    {
        itemPrefabs = Resources.LoadAll<GameObject>("Items");
    }

    private void Initialize()
    {
        Player = new Character(10, 10, 100, 0, itemPrefabs);
    }
}
