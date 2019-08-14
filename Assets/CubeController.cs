using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

    // キューブの移動速度
    private float speed = -0.2f;

    // 消滅位置
    private float deadLine = -10;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        // キューブを移動させる
        transform.Translate(this.speed, 0, 0);

        // 画面外に出たら破棄する
        if (transform.position.x < this.deadLine) {
            Destroy(gameObject);
        }
    }

    // 衝突時に呼ばれる関数
    void OnCollisionEnter2D(Collision2D collision) {
        // 地面かブロックに衝突したときSEを鳴らす
        if (collision.gameObject.tag == "GroundTag" || collision.gameObject.tag == "BlockTag") {
            GetComponent<AudioSource>().Play();
        }
    }
}
