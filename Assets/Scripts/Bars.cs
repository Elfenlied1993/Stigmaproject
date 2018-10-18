using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bars : MonoBehaviour {

    public int maxHealth, maxMana;
    public int curHealth, curMana;
    public Texture2D texHealth, texMana;



	void Start () {
        maxHealth = 200;
        maxMana = 200;
        curHealth = 195;
        curMana = 190;
	}
	
	// Update is called once per frame
	void Update () {
        if (curHealth > maxHealth) curHealth = maxHealth;
        if (curMana > maxMana) curMana = maxMana;
    }

    void OnGUI()
    {
        GUI.DrawTexture(new Rect(20, Screen.height - 370, curHealth, 80), texHealth);
        GUI.DrawTexture(new Rect(20, Screen.height - 350, curMana, 80), texMana);

    }
}
