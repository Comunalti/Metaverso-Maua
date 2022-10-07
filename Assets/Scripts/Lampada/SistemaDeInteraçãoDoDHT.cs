using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

public class SistemaDeInteraçãoDoDHT : MonoBehaviour
{
    [SerializeField] private TextMeshPro displayDeTemperatura;
    [SerializeField] private TextMeshPro displayDeHumidade;

    // Start is called before the first frame update
    async void Start()
    {
        StatusDHT statusDht = await ConectorDaAPI.conector.PegarInfosDht();

        displayDeTemperatura.text = $"{statusDht.Temp}°";
        displayDeHumidade.text = $"{statusDht.Hum}%";

        updateDosDisplay();
    }

    async void updateDosDisplay()
    {
        while (Application.isPlaying)
        {
            Task.Delay(1000).Wait();
            
            StatusDHT statusDht = await ConectorDaAPI.conector.PegarInfosDht();

            displayDeTemperatura.text = $"{statusDht.Temp}°";
            displayDeHumidade.text = $"{statusDht.Hum}%";
        }
    }
}
