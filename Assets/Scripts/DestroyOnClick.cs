﻿using UnityEngine;
using System.Collections;

public class DestroyOnClick : MonoBehaviour {

    // Update is called once per frame
    void Update() {

        if (Input.GetMouseButtonDown(0)) {

            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null) {
                if (hit.collider.gameObject == gameObject) {
                    Destroy(gameObject);
                }
            }
        }
    }

}
