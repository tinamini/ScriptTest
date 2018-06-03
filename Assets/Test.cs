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
	/// 防御する。
	/// </summary>
	/// <param name="damage">ダメージ</param>
	public void Defence(int damage)
	{
		this.hp -= damage;
		Debug.Log(damage + "のダメージを受けた");
	}
	#endregion
}
#endregion