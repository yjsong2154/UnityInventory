using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] private Button button;

    private Item itemDate;

    void Start()
    {
        button.onClick.AddListener(OnItemButtonClick);
        SetItem();
    }

    private void SetItem()
    {
        itemDate = GetComponent<Item>();
    }

    public void OnItemButtonClick()
    {
        GameManager.Instance.Player.Equip(itemDate);
    }
}
