using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class ManagerUIScript : MonoBehaviour
{
    private readonly CultureInfo cultureInfo = CultureInfo.InvariantCulture;
    private NumberStyles style = NumberStyles.Float;
    public Dropdown dropDown;
    public List<InputField> positionFields;
    public List<InputField> rotationFields;
    public List<InputField> sizeFields;
    public Transform cubeTransform;
    public Transform cameraTransform;
    public Transform pyramidTransform;

    void Start()
    {
        UpdateFields(cameraTransform);
    }

    public void ChangePositionX(string input)
    {
        if (!float.TryParse(input, style, cultureInfo, out var newValue))
        {
            return;
        }
        switch (dropDown.value)
        {
            case 0:
                var cameraPosition = cameraTransform.position;
                cameraPosition = new Vector3(newValue, cameraPosition.y, cameraPosition.z);
                cameraTransform.position = cameraPosition;
                break;
            case 1:
                var cubePosition = cubeTransform.position;
                cubePosition = new Vector3(newValue, cubePosition.y, cubePosition.z);
                cubeTransform.position = cubePosition;
                break;
            case 2:
                var pyramidPosition = pyramidTransform.position;
                pyramidPosition = new Vector3(newValue, pyramidPosition.y, pyramidPosition.z);
                pyramidTransform.position = pyramidPosition;
                break;
        }
    }
    
    public void ChangePositionY(string input)
    {
        if (!float.TryParse(input, style, cultureInfo, out var newValue))
        {
            return;
        }
        switch (dropDown.value)
        {
            case 0:
                var cameraPosition = cameraTransform.position;
                cameraPosition = new Vector3(cameraPosition.x, newValue, cameraPosition.z);
                cameraTransform.position = cameraPosition;
                break;
            case 1:
                var cubePosition = cubeTransform.position;
                cubePosition = new Vector3(cubePosition.x, newValue, cubePosition.z);
                cubeTransform.position = cubePosition;
                break;
            case 2:
                var pyramidPosition = pyramidTransform.position;
                pyramidPosition = new Vector3(pyramidPosition.x, newValue, pyramidPosition.z);
                pyramidTransform.position = pyramidPosition;
                break;
        }
    }
    
    public void ChangePositionZ(string input)
    {
        if (!float.TryParse(input, style, cultureInfo, out var newValue))
        {
            return;
        }
        switch (dropDown.value)
        {
            case 0:
                var cameraPosition = cameraTransform.position;
                cameraPosition = new Vector3(cameraPosition.x, cameraPosition.y, newValue);
                cameraTransform.position = cameraPosition;
                break;
            case 1:
                var cubePosition = cubeTransform.position;
                cubePosition = new Vector3(cubePosition.x, cubePosition.y, newValue);
                cubeTransform.position = cubePosition;
                break;
            case 2:
                var pyramidPosition = pyramidTransform.position;
                pyramidPosition = new Vector3(pyramidPosition.x, pyramidPosition.y, newValue);
                pyramidTransform.position = pyramidPosition;
                break;
        }
    }

    public void ChangeRotationX(string input)
    {
        if (!float.TryParse(input, style, cultureInfo, out var newValue))
        {
            return;
        }
        
        switch (dropDown.value)
        {
            case 0:
                var cameraRotation = cameraTransform.eulerAngles;
                cameraRotation = new Vector3(newValue, cameraRotation.y, cameraRotation.z);
                cameraTransform.eulerAngles = cameraRotation;
                break;
            case 1:
                var cubeRotation = cubeTransform.eulerAngles;
                cubeRotation = new Vector3(newValue, cubeRotation.y, cubeRotation.z);
                cubeTransform.eulerAngles = cubeRotation;
                break;
            case 2:
                var pyramidRotation = pyramidTransform.eulerAngles;
                pyramidRotation = new Vector3(newValue, pyramidRotation.y, pyramidRotation.z);
                pyramidTransform.eulerAngles = pyramidRotation;
                break;
        }
    }
    
    public void ChangeRotationY(string input)
    {
        if (!float.TryParse(input, style, cultureInfo, out var newValue))
        {
            return;
        }
        
        switch (dropDown.value)
        {
            case 0:
                var cameraRotation = cameraTransform.eulerAngles;
                cameraRotation = new Vector3(cameraRotation.x, newValue, cameraRotation.z);
                cameraTransform.eulerAngles = cameraRotation;
                break;
            case 1:
                var cubeRotation = cubeTransform.eulerAngles;
                cubeRotation = new Vector3(cubeRotation.x, newValue, cubeRotation.z);
                cubeTransform.eulerAngles = cubeRotation;
                break;
            case 2:
                var pyramidRotation = pyramidTransform.eulerAngles;
                pyramidRotation = new Vector3(pyramidRotation.x,newValue, pyramidRotation.z);
                pyramidTransform.eulerAngles = pyramidRotation;
                break;
        }
    }
    
    public void ChangeRotationZ(string input)
    {
        if (!float.TryParse(input, style, cultureInfo, out var newValue))
        {
            return;
        }
        switch (dropDown.value)
        {
            case 0:
                var cameraRotation = cameraTransform.eulerAngles;
                cameraRotation = new Vector3(cameraRotation.x, cameraRotation.y, newValue);
                cameraTransform.eulerAngles = cameraRotation;
                break;
            case 1:
                var cubeRotation = cubeTransform.eulerAngles;
                cubeRotation = new Vector3(cubeRotation.x, cubeRotation.y, newValue);
                cubeTransform.eulerAngles = cubeRotation;
                break;
            case 2:
                var pyramidRotation = pyramidTransform.eulerAngles;
                pyramidRotation = new Vector3(pyramidRotation.x, pyramidRotation.y, newValue);
                pyramidTransform.eulerAngles = pyramidRotation;
                break;
        }
    }
    
    public void ChangeScaleX(string input)
    {
        if (!float.TryParse(input, style, cultureInfo, out var newValue))
        {
            return;
        }

        switch (dropDown.value)
        {
            case 1:
                var cubeScale = cubeTransform.localScale;
                cubeScale = new Vector3(newValue, cubeScale.y, cubeScale.z);
                cubeTransform.localScale = cubeScale;
                break;
            case 2:
                var pyramidScale = pyramidTransform.localScale;
                pyramidScale = new Vector3(newValue, pyramidScale.y, pyramidScale.z);
                pyramidTransform.localScale = pyramidScale;
                break;
        }
    }
    
    public void ChangeScaleY(string input)
    {
        if (!float.TryParse(input, style, cultureInfo, out var newValue))
        {
            return;
        }
        
        switch (dropDown.value)
        {
            case 1:
                var cubeScale = cubeTransform.localScale;
                cubeScale = new Vector3(cubeScale.x, newValue, cubeScale.z);
                cubeTransform.localScale = cubeScale;
                break;
            case 2:
                var pyramidScale = pyramidTransform.localScale;
                pyramidScale = new Vector3(pyramidScale.x, newValue, pyramidScale.z);
                pyramidTransform.localScale = pyramidScale;
                break;
        }
    }
    
    public void ChangeScaleZ(string input)
    {
        if (!float.TryParse(input, style, cultureInfo, out var newValue))
        {
            return;
        }
        
        switch (dropDown.value)
        {
            case 1:
                var cubeScale = cubeTransform.localScale;
                cubeScale = new Vector3(cubeScale.x, cubeScale.y, newValue);
                cubeTransform.localScale = cubeScale;
                break;
            case 2:
                var pyramidScale = pyramidTransform.localScale;
                pyramidScale = new Vector3(pyramidScale.x, pyramidScale.y, newValue);
                pyramidTransform.localScale = pyramidScale;
                break;
        }
    }
    
    public void UpdateDropdown(int value)
    {
        switch (value)
        {
            case 0:
                UpdateFields(cameraTransform);
                break;
            case 1:
                UpdateFields(cubeTransform);
                break;
            case 2:
                UpdateFields(pyramidTransform);
                break;
        }
    }

    private void UpdateFields(Transform trans)
    {
        var position = trans.position;
        var rotation = trans.eulerAngles;
        var size = trans.localScale;
        positionFields[0].text = position.x.ToString(cultureInfo);
        positionFields[1].text = position.y.ToString(cultureInfo);
        positionFields[2].text = position.z.ToString(cultureInfo);
        rotationFields[0].text = rotation.x.ToString(cultureInfo);
        rotationFields[1].text = rotation.y.ToString(cultureInfo);
        rotationFields[2].text = rotation.z.ToString(cultureInfo);
        sizeFields[0].text = size.x.ToString(cultureInfo);
        sizeFields[1].text = size.y.ToString(cultureInfo);
        sizeFields[2].text = size.z.ToString(cultureInfo);
    }
}