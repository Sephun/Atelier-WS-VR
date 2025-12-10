using UnityEngine;

public class RotateReceptacleHorloge : MonoBehaviour
{
    public void GoRotateTest(float angle)
    {
        this.transform.Rotate(transform.up, angle);
    }
}
