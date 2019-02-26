using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FanCommand : MonoBehaviour {
    public WindEquation windEquantion;
    public Transform transformPontentiometer;
    public Transform transformBlade1;
    public ParticleSystem fumaca;
    public bool play;
    public float init = 1f;
    public float increment = 0.5f;
    public float speed;
    public Canvas blurFan;
    public MeshRenderer MeshFan;

    void Start () {
        var main = fumaca.main;
        play = false;
        fumaca.Stop();
        speed = 6;
        windEquantion.speed = speed;
        main.simulationSpeed = speed;
    }


    void Update() {

        var main = fumaca.main;
     

        main.simulationSpeed = speed;
        if (Input.GetKeyDown(KeyCode.F))
        {

            if (!play)
            {
                if (speed >= 5f)
                {
                    main.simulationSpeed = 5f;
                }
                play = true;
                fumaca.Play();

            }
            else
            {
                if (speed <= 0.5f)
                {
                    main.simulationSpeed = 0.5f;
                }
                play = false;
                fumaca.Stop();

            }

        }

        if ( Input.GetKeyDown(KeyCode.Equals)) {
            if (speed + increment < 17)
            {
                speed += increment;
                transformPontentiometer.Rotate(0, speed, 0);
            }
            
            if (play)
            {
                
                
                
                if (speed >= 5f)
                {
                    main.simulationSpeed = 5f;
                }

                
            }
        }
        if ( Input.GetKeyDown(KeyCode.Minus)) {
            if (speed - increment >= 0.5f)
            {
                speed -= increment;
                transformPontentiometer.Rotate(0, -speed, 0);
            }
            if (play)
            {
                if ((speed <= 0.5f))
                {
                    main.simulationSpeed = 0.5f;

                }

                
            }
        }
        if (speed <= 0.5)
        {

            speed = 0.5f;
            fumaca.Stop();

        }
        else
        {
            if (speed > 0.5 && play)
                fumaca.Play();
        }

            windEquantion.speed = speed;
        
        transformBlade1.Rotate(0, 0, windEquantion.speed);

    }   
}
