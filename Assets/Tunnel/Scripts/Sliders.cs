using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sliders : MonoBehaviour {

    public WindEquation windEquantion;
    public Slider sliderSecaoTransversal;
    public string tipo;
    public Text Label;

        void Start()
        {
            switch (tipo)
            {
                case "AreaTransversal":
                    sliderSecaoTransversal.value = windEquantion.crossSectional;
                    Label.text = "" + windEquantion.crossSectional.ToString("0.##");
                break;
                case "Densidade":
                    sliderSecaoTransversal.value = windEquantion.density;
                    Label.text = "" + windEquantion.density.ToString("0.##");
                break;
                case "DiametroHidraulico":
                    sliderSecaoTransversal.value = windEquantion.hydraulicDiameter;
                    Label.text = "" +  windEquantion.hydraulicDiameter.ToString("0.##");
                    break;
                case "Viscosidade":
                    sliderSecaoTransversal.value = windEquantion.viscosity;
                    Label.text = "" + windEquantion.viscosity.ToString("0.##");
                    break;
                case "Rugosidade":
                    sliderSecaoTransversal.value = windEquantion.relativeRugosity;
                    Label.text = "" + windEquantion.relativeRugosity.ToString("0.##");
                    break;
                case "Comprimento":
                    sliderSecaoTransversal.value = windEquantion.length;
                    Label.text = "" + windEquantion.length.ToString("0.##");
                break;
                case "Arrastro":
                    sliderSecaoTransversal.value = windEquantion.dragRate;
                    Label.text = "" + windEquantion.dragRate.ToString("0.##");
                break;
                case "AreaProjetada":
                    sliderSecaoTransversal.value = windEquantion.projectedArea;
                    Label.text = "" + windEquantion.projectedArea.ToString("0.##");
                break;
            }
        }
    //void Update()
    //{
    //    switch (tipo)
    //    {
    //        case "AreaTransversal":
    //            windEquantion.crossSectional = sliderSecaoTransversal.value ;
    //            Label.text = "" + windEquantion.crossSectional.ToString("0.##");
    //            break;
    //        case "Densidade":
    //            windEquantion.density = sliderSecaoTransversal.value ;
    //            Label.text = "" + windEquantion.density.ToString("0.##");
    //            break;
    //        case "DiametroHidraulico":
    //            windEquantion.hydraulicDiameter = sliderSecaoTransversal.value;
    //            Label.text = "" + windEquantion.hydraulicDiameter.ToString("0.##");
    //            break;
    //        case "Viscosidade":
    //            windEquantion.viscosity = sliderSecaoTransversal.value  ;
    //            Label.text = "" + windEquantion.viscosity.ToString("0.##");
    //            break;
    //        case "Rugosidade":
    //            windEquantion.relativeRugosity = sliderSecaoTransversal.value;
    //            Label.text = "" + windEquantion.relativeRugosity.ToString("0.##");
    //            break;
    //        case "Comprimento":
    //            windEquantion.length = sliderSecaoTransversal.value  ;
    //            Label.text = "" + windEquantion.length.ToString("0.##");
    //            break;
    //        case "Arrastro":
    //            windEquantion.dragRate = sliderSecaoTransversal.value ;
    //            Label.text = "" + windEquantion.dragRate.ToString("0.##");
    //            break;
    //        case "AreaProjetada":
    //            windEquantion.projectedArea = sliderSecaoTransversal.value ;
    //            Label.text = "" + windEquantion.projectedArea.ToString("0.##");
    //            break;

    //    }
    //}
    }
