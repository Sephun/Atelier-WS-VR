using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class CylinderXRRoationInteract : XRBaseInteractable
{
    [SerializeField] private Transform cylinder;

    public UnityEvent<float> OnWheelRotated;

    private float currentAngle = 0.0f; // permet d'actualiser la position quand on l'utilise et évite la remise à zero ou la charge quand on le laisse là sans intéragir
    
    protected override void OnSelectEntered(SelectEnterEventArgs args) //ce qui est appellé quand on prend l'objet
    {
        base.OnSelectEntered(args);
        currentAngle = FindWheelAngle();
    }

    protected override void OnSelectExited(SelectExitEventArgs args) //ce qui est appellé quand on lache l'objet
    {
        base.OnSelectExited(args);
        currentAngle = FindWheelAngle();
    }

    public override void ProcessInteractable(XRInteractionUpdateOrder.UpdatePhase updatePhase)
    {
        base.ProcessInteractable(updatePhase);
        if (updatePhase == XRInteractionUpdateOrder.UpdatePhase.Dynamic)
        {
            if (isSelected)
                RotateWheel();
        }
    }

    private void RotateWheel()
    {
        //Convertis la direction en angle puis en rotation
        float totalAngle = FindWheelAngle();
        
        //Applique la différence à la roue
        float angleDifference = currentAngle - totalAngle;
        cylinder.Rotate(transform.right, angleDifference);
        
        //enregistre l'angle pour la suite
        currentAngle = totalAngle;
        OnWheelRotated?.Invoke(angleDifference);
    }

    private float FindWheelAngle()
    {
        float totalAngle = 0;
        
        //combine la direction des interacteur actuel
        foreach (IXRSelectInteractor interactor in interactorsSelecting) //permet de trouver la direction quand on a 1 ou 2 mains dessus
        {
            Vector2 direction = FindLocalPoint(interactor.transform.position);
            totalAngle += ConvertToAngle(direction) * FindRotationSensivity();
        }
        
        return totalAngle;
    }

    private Vector2 FindLocalPoint(Vector3 position)
    {
        //convertis la position de la main en local pour facilement trouver l'angle
        return transform.InverseTransformPoint(position).normalized;
    }

    private float ConvertToAngle(Vector2 direction)
    {
        //utilise une direction constante pour trouver l'angle
        return Vector2.SignedAngle(transform.up, direction);
    }

    private float FindRotationSensivity()
    {
        //utilise une plus petite sensibilité avec 2 mains, qui scale donc.
        return 1.0f / interactorsSelecting.Count;
    }
}