using UnityEngine;

public class SelectionSteps : MonoBehaviour
{
    public GameObject[] steps; // Gösterilecek nesneler
    private int currentStep = 0;

    void OnMouseDown() // Nesneye tıklama algılayıcı
    {
        if (currentStep < steps.Length)
        {
            steps[currentStep].SetActive(true); // Şu anki adımı göster
            if (currentStep > 0)
            {
                steps[currentStep - 1].SetActive(false); // Önceki adımı gizle
            }
            currentStep++;
        }
    }
}
