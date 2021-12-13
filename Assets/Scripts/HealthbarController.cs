using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthbarController : MonoBehaviour
{
    //Precisa Por um Slider e Visualizar a Vida de Acordo com o Valor do Slider na tela;
    public Image healthBar;
    private float health;
    public float startHealth;

    private void Start()
    {
        //healthBar.value = startHealth;
    }

    public void onTakeDamage(int damage)
    {
        //health = health - damage;
        //healthBar.value = health / startHealth;
    }

    public void onGainLife(int heal)
    {
        //health = health + heal;
        //healthBar.value = health / startHealth;
    }


}
