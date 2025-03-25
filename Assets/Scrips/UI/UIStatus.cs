using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIStatus : MonoBehaviour
{
    [SerializeField] private Button backButton;
    private Character player;

    [SerializeField] private TextMeshProUGUI attackText;
    [SerializeField] private TextMeshProUGUI defenceText;
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private TextMeshProUGUI criticalText;

    void Start()
    {
        backButton.onClick.AddListener(OnBackButtonClicked);
        player = GameManager.Instance.Player;
        Text[] texts = GetComponentsInChildren<Text>();

        UpdateUI();
    }

    private void UpdateUI()
    {
        attackText.text = $"Attack - {player.Attack}";
        defenceText.text = $"Defence - {player.Defence}";
        healthText.text = $"Health - {player.Health}";
        criticalText.text = $"Critical - {player.Critical}";
    }

    private void OnBackButtonClicked()
    {
        UIManager.Instance.HideAllUI();
        UIManager.Instance.MainManu.gameObject.SetActive(true);
    }
}
