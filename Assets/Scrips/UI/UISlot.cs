using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private Image isEquip;

    private Item itemDate;

    void Start()
    {
        button.onClick.AddListener(OnItemButtonClick);
        GameManager.Instance.Player.RefreshSlot += RefreshUI;
        SetItem();
    }

    private void SetItem()
    {
        itemDate = GetComponent<Item>();
    }

    private void RefreshUI()
    {
        if (GameManager.Instance.Player.equipItem == itemDate)
        {
            isEquip.gameObject.SetActive(true);
        }
        else
        {
            isEquip.gameObject.SetActive(false);
        }
    }

    public void OnItemButtonClick()
    {
        GameManager.Instance.Player.Equip(itemDate);
        RefreshUI();
    }
}
