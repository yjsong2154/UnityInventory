using UnityEngine;
using UnityEngine.Timeline;

public class Character
{
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
}
