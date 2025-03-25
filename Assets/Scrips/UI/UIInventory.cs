using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private Button backButton;

    void Start()
    {
        backButton.onClick.AddListener(OnBackButtonClicked);
    }

    private void OnBackButtonClicked()
    {
        UIManager.Instance.HideAllUI();
        UIManager.Instance.MainManu.gameObject.SetActive(true);
    }
}
