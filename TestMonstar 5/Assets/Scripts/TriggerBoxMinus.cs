﻿using UnityEngine;
using System.Collections;

public class TriggerBoxMinus : MonoBehaviour {

		// Use this for initialization
		void OnTriggerEnter(Collider col) {
			if(col.tag.Equals("Player")) {
				Application.LoadLevel(Application.loadedLevel-1);
			}
		}
	}