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
        Debug.Log($"아이템 프리팹 {itemPrefabs.Length}개 로드됨");
    }

    private void Initialize()
    {
        Debug.Log($"아이템 프리팹 {itemPrefabs.Length}개 전달");
        Player = new Character(10, 10, 100, 0, itemPrefabs);
    }
}
