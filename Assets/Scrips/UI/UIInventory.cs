using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private Button backButton;
    [SerializeField] private RectTransform content;
    [SerializeField] private GameObject EmptySlot;

    void Start()
    {
        backButton.onClick.AddListener(OnBackButtonClicked);

        for (int i = 0; i < 120; i++)
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
