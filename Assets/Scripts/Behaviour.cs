using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beh : MonoBehaviour
{
    
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TowerTakeDmg(20);
            Debug.Log(GameManager.gameManager._towerHealth.Health);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            TowerHeal(20);
            Debug.Log(GameManager.gameManager._towerHealth.Health);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

    private void TowerTakeDmg(int dmg)
    {
        GameManager.gameManager._towerHealth.DmgUnit(dmg);
    }

    private void TowerHeal(int healing)
    {
        GameManager.gameManager._towerHealth.HealUnit(healing);
    }
}
