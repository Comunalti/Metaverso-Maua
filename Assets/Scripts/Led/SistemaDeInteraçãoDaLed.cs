using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SistemaDeInteraçãoDaLed : MonoBehaviour
{
    [SerializeField] private List<Light> componentesDeLed;
    
    [SerializeField] private Slider componenteDeSliderR;
    [SerializeField] private Slider componenteDeSliderG;
    [SerializeField] private Slider componenteDeSliderB;
    
    // Start is called before the first frame update
    async void Start()
    {
       StatusLed infosLed  = await ConectorDaAPI.conector.PegarInfosLed();

       componenteDeSliderR.value = infosLed.R;
       componenteDeSliderG.value = infosLed.G;
       componenteDeSliderB.value = infosLed.B;
    }

    private async void trocarValoresLed(int R, int G,int B)
    {
        await ConectorDaAPI.conector.SetarStatusLed(true, R, G, B);
    }

    public void trocarR(int valor)
    {
        trocarValoresLed(valor,(int) componenteDeSliderG.value,(int) componenteDeSliderB.value);
    }

    public void trocarB(int valor)
    {
        trocarValoresLed((int) componenteDeSliderR.value,valor,(int) componenteDeSliderB.value);
    }

    public void trocarG(int valor)
    {
        trocarValoresLed((int) componenteDeSliderR.value,(int) componenteDeSliderG.value,valor);
    }
}
