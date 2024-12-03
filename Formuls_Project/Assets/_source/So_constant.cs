using UnityEngine;

[CreateAssetMenu(fileName = "SoConstant", menuName = "Constant")]
public class So_constant : ScriptableObject
{
    [SerializeField] private float g = 9.81f;
    [SerializeField] private float G = 6.67f*(10^(-11));
    [SerializeField] private int c = 3 * (10^8);

    public static float GValue => Instance.G;
    public static float GAcceleration => Instance.g;
    public static int LightSpeed => Instance.c;

    private static So_constant _instance;

    public static So_constant Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = Resources.Load<So_constant>("SoConstant");

            }
            return _instance;
        }
    }
}
