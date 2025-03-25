using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

    [SerializeField] private UIMainManu uIMainManu;
    [SerializeField] private UIInventory uIInventory;
    [SerializeField] private UIStatus uIStatus;

    public UIMainManu MainManu => uIMainManu;
    public UIStatus Status => uIStatus;
    public UIInventory Inventory => uIInventory;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void HideAllUI()
    {
        uIMainManu.gameObject.SetActive(false);
        uIInventory.gameObject.SetActive(false);
        uIStatus.gameObject.SetActive(false);
    }
}
