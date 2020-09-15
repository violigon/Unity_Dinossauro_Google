using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public Rigidbody2D rb;

    public float forcaPulo;

    public LayerMask layerChao;

    private bool estaNoChao;

    public float distanciaMinimaChao = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Pular();
        }
    }
    void Pular()
    {
        if (estaNoChao)
            rb.AddForce(Vector2.up * forcaPulo);
    }
    private void FixedUpdate()
    {
        estaNoChao = Physics2D.Raycast(transform.position, Vector2.down, distanciaMinimaChao, layerChao);
    }
}
