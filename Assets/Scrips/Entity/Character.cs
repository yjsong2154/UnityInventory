using UnityEngine;
using UnityEngine.Timeline;

public class Character
{
    public Item equipItem;
    public int Attack;
    public int Defence;
    public int Health;
    public int Critical;

    public Character(int attack, int defence, int health, int critical)
    {
        Attack = attack;
        Defence = defence;
        Health = health;
        Critical = critical;
    }

    public void Equip(Item item)
    {
        Debug.Log("장비");
        if (equipItem == item)
        {
            unEquip();
            Debug.Log($"해제 {Attack}, {Defence}, {Health}, {Critical}");
        }
        else
        {
            unEquip();
            Attack += item.Attack;
            Defence += item.Defence;
            Health += item.Health;
            Critical += item.Critical;
            equipItem = item;
            Debug.Log($"착용 {Attack}, {Defence}, {Health}, {Critical}");
        }
    }

    private void unEquip()
    {
        if (equipItem != null)
        {
            Attack -= equipItem.Attack;
            Defence -= equipItem.Defence;
            Health -= equipItem.Health;
            Critical -= equipItem.Critical;
            equipItem = null;
        }
    }
}
