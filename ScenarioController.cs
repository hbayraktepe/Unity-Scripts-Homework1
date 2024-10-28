using UnityEngine;

public class ScenarioController : MonoBehaviour
{
    public GameObject scenario1Objects;
    public GameObject scenario2Objects;

    public void ShowScenario1()
    {
        Debug.Log("Scenario 1 Aktif");
        scenario1Objects.SetActive(true);
        scenario2Objects.SetActive(true);
    }

    public void ShowScenario2()
    {
        Debug.Log("Scenario 2 Aktif");
        scenario1Objects.SetActive(false);
        scenario2Objects.SetActive(false);
    }
}