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
       await ConectorDaAPI.conector.SetarStatusLed(true, 255,255, 255);
    }

    public async void trocarValoresLed()
    {
        foreach (Light luz in componentesDeLed)
        {
            luz.color = new Color(componenteDeSliderR.value/255, componenteDeSliderG.value/255,
                componenteDeSliderB.value/255);
        }
        
        await ConectorDaAPI.conector.SetarStatusLed(true, (int) componenteDeSliderR.value,(int) componenteDeSliderG.value, (int) componenteDeSliderB.value);
    }
}
