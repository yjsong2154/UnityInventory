using UnityEngine;
using UnityEngine.UI;

public class UIMainManu : MonoBehaviour
{
    [SerializeField] private Button statusUIButton;
    [SerializeField] private Button inventoryUIButton;

    void Start()
    {
        statusUIButton.onClick.AddListener(OpenStatus);
        inventoryUIButton.onClick.AddListener(OpenInventory);
    }

    private void OpenStatus()
    {
        UIManager.Instance.HideAllUI();
        UIManager.Instance.Status.gameObject.SetActive(true);
    }

    private void OpenInventory()
    {
        UIManager.Instance.HideAllUI();
        UIManager.Instance.Inventory.gameObject.SetActive(true);
    }
}
