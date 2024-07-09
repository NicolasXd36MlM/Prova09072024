using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    #region Singleton
    public static UIManager instance;

    private void Awake()
    {
        instance = this;
    }
    #endregion




    [SerializeField] Sprite sprites();
    [SerializeField] Image imagens();
    [SerializeField] TextMeshProUGUI textoDePontuacao();
    [SerializeField] TextMeshProUGUI textoDoRelogio();


        // Método público para atualizar as setas
        public void AtualizarSetas(setas.Keycode)
        {
            // Loop para cada imagem no array imagens
            {
                // Se o índice for maior ou igual ao comprimento do array setas
                {
                    // Define a sprite como a primeira do array sprites
                }
                // Se a tecla for DownArrow
                {
                    // Define a sprite como a segunda do array sprites
                }
                // Se a tecla for UpArrow
                {
                    // Define a sprite como a terceira do array sprites
                }
                // Se a tecla for LeftArrow
                {
                    // Define a sprite como a quarta do array sprites
                }
                // Se a tecla for RightArrow
                {
                    // Define a sprite como a quinta do array sprites
                }

                // Define a cor da imagem como branca
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
