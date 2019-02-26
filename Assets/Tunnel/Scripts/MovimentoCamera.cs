using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoCamera : MonoBehaviour {

    public Transform transformCamera;
    public Transform transformPai;
    public Vector3 rotacaoLocal;
    public float velocidadeRotacao = 1f;
    public float distanciaCamera;
    public float sensibilidadeMouse = 4f;
    public float sensibilidadeScroll = 2f;
    //public float velocidadeOrbirtar = 10f;
    public float diminuirScroll = 6f;
    public float diminuirOrbita = 1f;
    public bool cameraDesabilitada = false;

    void Start()
    {
        this.transformCamera = this.transform;
        this.transformPai = this.transform.parent;
    }
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
            cameraDesabilitada = !cameraDesabilitada;
        if (!cameraDesabilitada)
        {
            if (Input.GetKey(KeyCode.Mouse1))
            {


                if (Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
                {
                    rotacaoLocal.x += Input.GetAxis("Mouse X") * sensibilidadeMouse;
                    rotacaoLocal.y -= Input.GetAxis("Mouse Y") * sensibilidadeMouse;

                    rotacaoLocal.y = Mathf.Clamp(rotacaoLocal.y, 0f, 90f);
                }

                if (Input.GetAxis("Mouse ScrollWheel") != 0f)
                {
                    float scrollAtual = Input.GetAxis("Mouse ScrollWheel") * sensibilidadeScroll;

                    scrollAtual *= (this.distanciaCamera * 0.3f);


                    this.distanciaCamera += scrollAtual * -1f;

                    this.distanciaCamera = Mathf.Clamp(rotacaoLocal.y, 1.5f, 100f);
                }

                Quaternion qT = Quaternion.Euler(rotacaoLocal.y, rotacaoLocal.x, 0);
                this.transformPai.rotation = Quaternion.Lerp(this.transformPai.rotation, qT, Time.deltaTime * diminuirOrbita);

                //if (this.transformCamera.localPosition.z != this.distanciaCamera * -1f)
                //{
                //    this.transformCamera.localPosition = new Vector3(0f, 0f, Mathf.Lerp(this.transformCamera.localPosition.z, this.distanciaCamera * -1f, Time.deltaTime * diminuirScroll));
                //}
            }
        }
    }
    void Update()
    {
        Vector3 posicao = transform.position;

        if (Input.GetKey(KeyCode.W))
        {
            posicao.x -= velocidadeRotacao;
        }

        if (Input.GetKey(KeyCode.S))
        {
            posicao.x += velocidadeRotacao;
        }

        if (Input.GetKey(KeyCode.D))
        {
            posicao.z += velocidadeRotacao;
        }

        if (Input.GetKey(KeyCode.A))
        {
            posicao.z -= velocidadeRotacao;
        }

        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            posicao = new Vector3(transform.position.x, transform.position.y - 10f, transform.position.z + 10f);
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            posicao = new Vector3(transform.position.x, transform.position.y + 10f, transform.position.z - 10f);
        }
        transform.position = posicao;

    }
}
