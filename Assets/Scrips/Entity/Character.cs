using UnityEngine;
using UnityEngine.Timeline;

public class Character
{
    public Item equipItem;
    public int Attack;
    public int Defence;
    public int Health;
    public int Critical;
    public GameObject[] Inventory;

    public Character(int attack, int defence, int health, int critical, GameObject[] inventory)
    {
        Attack = attack;
        Defence = defence;
        Health = health;
        Critical = critical;
        Inventory = inventory;
    }

    public void Equip(Item item)
    {
        if (equipItem == item)
        {
            unEquip();
        }
        else
        {
            unEquip();
            Attack += item.Attack;
            Defence += item.Defence;
            Health += item.Health;
            Critical += item.Critical;
            equipItem = item;
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
