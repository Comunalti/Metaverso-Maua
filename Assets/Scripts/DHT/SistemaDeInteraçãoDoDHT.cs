using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

public class SistemaDeInteraçãoDoDHT : MonoBehaviour
{
    [SerializeField] private SistemaDeInteraçãoDeGrafico graficoDeTemperatura;
    [SerializeField] private SistemaDeInteraçãoDeGrafico graficoDeHumidade;

    private void Start()
    {
        updateDosDisplay();
    }

    async void updateDosDisplay()
    {
        while (Application.isPlaying)
        {
            StatusDHT statusDht = await ConectorDaAPI.conector.PegarInfosDht();
        
            graficoDeTemperatura.atualizarValor(statusDht.Temp);
            graficoDeHumidade.atualizarValor(statusDht.Hum);
            
            Task.Delay(1000).Wait();
        }
    }
}
