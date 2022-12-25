using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public float Velocidade = 10;

    // Update is called once per frame
    void Update()
    {
        // pega o eixo
        float eixoX = Input.GetAxis("Horizontal");
        float eixoZ = Input.GetAxis("Vertical");

        Vector3 direcao = new Vector3(eixoX, 0, eixoZ);

        // movimenta no vetor x,y e z
        transform.Translate(direcao * Velocidade * Time.deltaTime);

        // pergunta se está se movendo ou não, para correr ou não
        if (direcao != Vector3.zero)
        {
            GetComponent<Animator>().SetBool("Movendo", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("Movendo", false);
        }
    }
}
