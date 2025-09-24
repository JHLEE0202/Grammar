using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      Player Myplayer = new Player();
      Myplayer.Attack();
      Myplayer.Damage(35);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // 클래스는 비슷한 속성, 특성, 멤버 => 변수, 매서드
    public class Player 
    {
      //공격
      private int HP = 100;
      private int POWER = 50;
      public void Attack()
      {
        Debug.Log(this.POWER + "데미지를 입혔다");
      }
      public void Damage(int Damage)
      {
        this.HP = Damage;
        Debug.Log(Damage + "데미지를 입혔다");
      }
    }
    
}
