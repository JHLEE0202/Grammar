using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Monster slime = new Monster("슬라임"); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public class Monster
    {
    
    private string name;
    private int Hp;
    private int power;

    public void Monster(string name);
    {
        this.name = name;
        this.int Hp = 100;
        thos.int power = 50;
        
    }
    
    public void Attack()
    {
        Debug.Log("name이가" + this.power + "공격력 만큼 공격했다");
    }

    public void Damage(int Damage)
    {
        this.Hp -= power
        Debug.Log("name이가" + this.Damage + "데미지를 입었다");  
    }

    public void Hp()
    {
        Debug.Log("name이의 현재 체력은" + this.Damage );
    }
    
    public void Heal(int amount)
    {
        this.Hp += 30
        Debug.Log("체력 회복 후 name 이(가)" + this.amount + "만큼 회복했다.");
    }
    }
    
}
