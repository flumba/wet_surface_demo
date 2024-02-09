using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class PassMeshToVisualEffect : MonoBehaviour
{
    [SerializeField][HideInInspector]
    MeshFilter _meshFilter;
    [SerializeField][HideInInspector]
    VisualEffect _visualEffect;

    private void OnValidate()
    {
        if(_meshFilter == null)
        {
            _meshFilter = GetComponent<MeshFilter>();
        }
        if(_visualEffect == null)
        {
            _visualEffect = GetComponent<VisualEffect>();
        }
        if(_meshFilter != null && _visualEffect != null)
        {
            _visualEffect.SetMesh("Input Mesh", _meshFilter.sharedMesh);
        }
    }


}
