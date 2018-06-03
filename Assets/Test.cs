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