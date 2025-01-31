using UnityEngine;

public class BackgroundGrassRings : MonoBehaviour
{
    int healthPerRing = 25;

    [SerializeField] GameObject[] aliveRings;
    [SerializeField] GameObject[] deadRings;


    //[SerializeField] int ring;
    private void Start()
    {
        SetActiveRings(4);
    }

    public void GetActiveRingsByHealth(int health)    // pasar aqui vida
    {
        SetActiveRings(health / healthPerRing);
    }

    public void SetActiveRings(int ring)
    {
        for (int i = 0; i < 4; i++)
        {
            aliveRings[i].SetActive(ring > i);
            deadRings[i].SetActive(ring <= i);
        }
    }
}
