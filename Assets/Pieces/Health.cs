using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    private double health;
    public Health(double max)
    {
        health = max;
    }
    public void heal(double amount)
    {
        health += amount;
    }
    public void hit(double amount)
    {
        health -= amount;
    }
    public void changePercentage(double amount)
    {
        health *= amount / 100;
    }
}
