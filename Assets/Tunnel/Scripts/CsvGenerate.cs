using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System;

public class CsvGenerate : MonoBehaviour {

    private List<string[]> rowData = new List<string[]>();
    public WindEquation windEquantion;
    void Save()
    {

        string[] rowDataTemp = new string[7];
        rowDataTemp[0] = "Vazao Volumetrica";
        rowDataTemp[1] = "Fator Atrito";
        rowDataTemp[2] = "Vazao Massica";
        rowDataTemp[3] = "Perda de Carga";
        rowDataTemp[4] = "Pressao Dinamica";
        rowDataTemp[5] = "Forca de Arrastro";
        rowDataTemp[6] = "Numero de Reynolds";
        rowData.Add(rowDataTemp);

        for (int i = 0; i < 1; i++)
        {
            rowDataTemp = new string[7];
            rowDataTemp[0] = windEquantion.volumetricFlow(windEquantion.speed).ToString();
            rowDataTemp[1] = windEquantion.frictionFactor(windEquantion.speed).ToString();
            rowDataTemp[2] = windEquantion.massFlow(windEquantion.speed).ToString();
            rowDataTemp[3] = windEquantion.chargeLoss(windEquantion.speed).ToString();
            rowDataTemp[4] = windEquantion.DynamicPressure(windEquantion.speed).ToString();
            rowDataTemp[5] = windEquantion.drag(windEquantion.speed).ToString();
            rowDataTemp[6] = windEquantion.ReynoldsNumber(windEquantion.speed).ToString();
            rowData.Add(rowDataTemp);
        }

        string[][] output = new string[rowData.Count][];

        for (int i = 0; i < output.Length; i++)
        {
            output[i] = rowData[i];
        }

        int length = output.GetLength(0);
        string delimiter = ",";

        StringBuilder sb = new StringBuilder();

        for (int index = 0; index < length; index++)
            sb.AppendLine(string.Join(delimiter, output[index]));


        string filePath = getPath();

        StreamWriter outStream = System.IO.File.CreateText(filePath);
        outStream.WriteLine(sb);
        outStream.Close();
    }
    void Update() {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Save();
        }
    }
        private string getPath()
        {
            #if UNITY_EDITOR
             return Application.dataPath + "/Exportacao/" + "Saved_data.csv";
            #elif UNITY_ANDROID
             return Application.persistentDataPath+"Saved_data.csv";
            #elif UNITY_IPHONE
             return Application.persistentDataPath+"/"+"Saved_data.csv";
            #else
             return Application.dataPath +"/Exportacao/"+"Saved_data.csv";
            #endif
    }
}

