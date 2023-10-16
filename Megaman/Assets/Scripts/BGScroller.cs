using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroller : MonoBehaviour {

    public float speed = 0;
    private Material mat;
    private GameObject player;

    private float pos = 0;

    // Use this for initialization
    void Start () {
        mat = GetComponent<Renderer>().material;
        player = GameObject.FindGameObjectWithTag("Player");
    }
    
    // Update is called once per frame
    void Update () {
        // Obtenha a velocidade atual do jogador.
        float playerVelocityX = player.GetComponent<Rigidbody2D>().velocity.x;

        // Verifique se o jogador está se movendo horizontalmente.
        if (Mathf.Abs(playerVelocityX) > 0.1f) {
            pos += speed * playerVelocityX * Time.deltaTime; // Use Time.deltaTime para suavizar o movimento.
            mat.mainTextureOffset = new Vector2(pos, 0);
        }
    }
}
