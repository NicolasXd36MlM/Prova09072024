using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UImanager : MonoBehaviour
{
    #region Singleton
    public static UImanager instance;


    private void Awake()
    {
        instance = this;
    }
    #endregion



    [SerializeField] Sprite sprites();
    [SerializeField] Image imagens();
    [SerializeField] TextMeshProUGUI textoDePontuacao();
    [SerializeField] TextMeshProUGUI textoDoRelogio();


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
