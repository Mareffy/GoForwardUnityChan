﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
	//Audiosource
	AudioSource audiosource;

	//キューブの移動速度
	private float speed = -12;

	//消滅位置
	private float deadLine = -10;

	// Use this for initialization
	void Start ()
	{
		//AudioSourceのコンポーネントを取得する
		this.audiosource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		//キューブを移動させる
		transform.Translate(this.speed *Time.deltaTime,0,0);

		//画面外に出たら破棄する
		if(transform.position.x < this.deadLine)
		{
			Destroy(gameObject);
		}		
	}
	void OnCollisionEnter2D(Collision2D collision)
	{	
		
		//Unityちゃん以外のオブジェクトに当たった時に効果音を鳴らしたい
		if(gameObject.tag == "CubeTag"|| gameObject.tag == "GroundTag")
		{	
	
			audiosource.Play();	
		}
		
	}
}
