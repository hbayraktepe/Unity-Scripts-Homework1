using UnityEngine;

public class StepController : MonoBehaviour
{
    public GameObject[] steps; 
    private int currentStep = 0;

    void Start()
    {
        foreach (GameObject step in steps)
            step.SetActive(false);

        if (steps.Length > 0)
            steps[0].SetActive(true);
    }

    public void NextStep()
    {
        if (currentStep < steps.Length - 1)
        {
            steps[currentStep].SetActive(false); 
            currentStep++;
            steps[currentStep].SetActive(true); 
        }
    }
}
