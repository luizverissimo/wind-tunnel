using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Report : MonoBehaviour {

    public WindEquation windEquantion;
    public Canvas informationReport;
    public Canvas variableReport;
    public Text reportVariable;
    public Text reportInformation;
    public GameObject Esfera;
    public GameObject Carro;


    void Start () {
        informationReport.enabled = false;
        variableReport.enabled = false;
    }
	
	void Update () {



        if (Carro.active) reportVariable.text = "Resultados Túnel Geometria Carro \n\n";
        if (Esfera.active) reportVariable.text = "Resultados Túnel Geometria Esfera \n\n";
        reportVariable.text += "Velocidade: " + windEquantion.speed.ToString("0.##") + " m/s \n";
        
        reportVariable.text += "Vazão Volumétrica: " + windEquantion.volumetricFlow(windEquantion.speed).ToString("0.##") + " m³/s \n";
        
        reportVariable.text += "Vazão Mássica: " + windEquantion.massFlow(windEquantion.speed).ToString("0.##") + " kg/s \n";
        reportVariable.text += "Pressão Dinâmica: " + windEquantion.DynamicPressure(windEquantion.speed).ToString("0.##") + " Pa \n";
        reportVariable.text += "Número de Reynolds: " + windEquantion.ReynoldsNumber(windEquantion.speed).ToString("0.##") + "\n";
        reportVariable.text += "Fator Atrito: " + windEquantion.frictionFactor(windEquantion.speed).ToString("0.##") + "\n";
        reportVariable.text += "Perda de Carga: " + windEquantion.chargeLoss(windEquantion.speed).ToString("0.##") + " Pa \n";
        reportVariable.text += "Força de Arrasto: " + windEquantion.drag(windEquantion.speed).ToString("0.##") + " N \n\n";
        reportVariable.text += "Propriedades do ar a T = 27°C\n";
        reportVariable.text += "Massa Específica = 1.1614 kg/m³\n";
        reportVariable.text += "Volume Específico  = 0.8610 m³/kg\n";
            reportVariable.text += "Viscosidade dinamica = 1.85 x 10^-5 N.s/M²\n";



        if (Input.GetKeyDown(KeyCode.F1)) {
            if (!informationReport.enabled)
            {
                informationReport.enabled = true;
                variableReport.enabled = false;
                reportInformation.enabled = true;
                reportVariable.enabled = false;
            } else
            {
                informationReport.enabled = false;
                variableReport.enabled = false;
                reportInformation.enabled = false;
                reportVariable.enabled = false;
            }
            
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            if (!variableReport.enabled)
            {
                informationReport.enabled = false;
                variableReport.enabled = true;
                reportInformation.enabled = false;
                reportVariable.enabled = true;
            } else
            {
                informationReport.enabled = false;
                variableReport.enabled = false;
                reportInformation.enabled = false;
                reportVariable.enabled = false;
            }
            
        }

        if (Carro.active) windEquantion.projectedArea = 0.007854f;
        if (Esfera.active) windEquantion.projectedArea = 0.0225f;

    }
}
