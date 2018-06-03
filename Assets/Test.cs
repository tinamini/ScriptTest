using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#region Test Class
public class Test : MonoBehaviour
{
	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start()
	{
		// 課題：配列を宣言して出力
		this.DisplayIntArray();

		var lastBoss = new Boss();

		// 攻撃
		lastBoss.Attack();

		// 防御
		lastBoss.Defence(3);

		// 魔法攻撃
		for (var i = 0; i < 15; i++)
		{
			Debug.Log(i + 1 + "回目の魔法攻撃。");
			lastBoss.Magic(5);
		}
	}

	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update()
	{

	}

	#region Private Method
	/// <summary>
	/// 配列を表示する
	/// </summary>
	/// <remarks>
	/// 配列を順番・逆番に表示する
	/// </remarks>
	private void DisplayIntArray()
	{
		const int num = 5;
		var array = new int[num] { 10, 20, 30, 40, 50 };

		// 順番
		Debug.Log("順番に配列を表示");
		for (var i = 0; i < num; i++)
		{
			Debug.Log(array[i]);
		}

		// 逆番
		Debug.Log("逆番に配列を表示");
		for (var i = num - 1; i >= 0; i--)
		{
			Debug.Log(array[i]);
		}
	}
	#endregion
}
#endregion

#region Boss Class
/// <summary>
/// Boss クラス
/// </summary>
public class Boss
{
	#region Field
	/// <summary>
	/// 体力
	/// </summary>
	private int hp = 100;

	/// <summary>
	/// 攻撃力
	/// </summary>
	private int power = 25;

	/// <summary>
	/// 魔力
	/// </summary>
	private int mp = 53;
	#endregion

	#region Public Method
	/// <summary>
	/// 攻撃する
	/// </summary>
	public void Attack()
	{
		Debug.Log(this.power + "のダメージを与えた");
	}

	/// <summary>
	/// 防御する
	/// </summary>
	/// <param name="damage">ダメージ</param>
	public void Defence(int damage)
	{
		this.hp -= damage;
		Debug.Log(damage + "のダメージを受けた");
	}

	/// <summary>
	/// 魔法攻撃をする
	/// </summary>
	/// <param name="needMp">必要魔力</param>
	public void Magic(int needMp)
	{
		if (this.mp >= needMp)
		{
			this.mp -= needMp;
			Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
		}
		else
		{
			Debug.Log("MPが足りないため魔法が使えない。");
		}
	}
	#endregion
}
#endregion