using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private Button backButton;
    [SerializeField] private RectTransform content;
    [SerializeField] private GameObject EmptySlot;

    private GameObject[] playerInventory;

    void Start()
    {
        backButton.onClick.AddListener(OnBackButtonClicked);
        playerInventory = GameManager.Instance.Player.Inventory;

        for (int i = 0; i < playerInventory.Length; i++)
        {
            GameObject itemSlot = Instantiate(playerInventory[i], content);
        }

        for (int i = 0; i < 120 - playerInventory.Length; i++)
        {
            GameObject NoneSlot = Instantiate(EmptySlot, content);
        }
    }

    private void OnBackButtonClicked()
    {
        UIManager.Instance.HideAllUI();
        UIManager.Instance.MainManu.gameObject.SetActive(true);
    }
}
