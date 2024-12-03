using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "SoFormulView", menuName = "FormulView")]
public class So_FormulView : ScriptableObject
{
    [SerializeField] private string _formula;
    [SerializeField] private int id;
    public string Formula => _formula;

    public int Id => id;
}
