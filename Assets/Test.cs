using UnityEngine;
using System.Collections;

public class Boss
{
    private int hp = 100; //体力
    private int power = 25; //攻撃力
    public int mp = 53; //魔力

    //攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    //防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }

    //◆◆◆発展課題◆◆◆
    //魔法攻撃用の関数
    public void Magic(int magicattack)
    {
        this.mp -= magicattack;

        if(this.mp >= 5){
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }
        else{
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }

}


public class Test : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

        //◆◆◆課題◆◆◆
        //要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化
        int[] array = { 1, 2, 3, 4, 5 };

        //配列の各要素の値を順番に表示
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        //for文を使い、配列の各要素の値を逆順に表示
        for (int j = array.Length-1; j >= 0; j--)
        {
            Debug.Log(array[j]);
        }

        //◆◆◆発展課題◆◆◆
        //Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        //攻撃用の関数を呼び出す
        lastboss.Attack();

        //防御用の関数を呼び出す
        lastboss.Defence(3);

        //魔法攻撃ができるかどうかを除算で判別
        //魔法攻撃に必要なmp値
        int magical = 5;
        //魔法攻撃ができる回数
        int magicalnum = lastboss.mp / magical;

        //魔法攻撃用の関数を呼び出す
        for (int i = 0; i < magicalnum; i++)
        {
            lastboss.Magic(magical);
        }

    }

    // Update is called once per frame
    void Update () {
		
	}
}
