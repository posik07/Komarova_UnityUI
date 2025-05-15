using UnityEngine;
using UnityEngine.UI;

public class CharacterInfoController : MonoBehaviour
{
    public Dropdown characterDropdown;
    public Text infoText;

    private void Start()
    {
        characterDropdown.onValueChanged.AddListener(OnDropdownChanged);
        UpdateInfoText(0); // начальный текст
    }

    private void OnDropdownChanged(int index)
    {
        UpdateInfoText(index);
    }

    private void UpdateInfoText(int index)
    {
        switch (index)
        {
            case 0:
                infoText.text = "Mazā meitene vārdā Elīna ļoti mīl zīmēt. Viņa bieži pavada laiku parkā ar savu kaķīti un sapņo kļūt par mākslinieci.";
                break;
            case 1:
                infoText.text = "Jānis ir ziņkārīgs zēns, kurš vienmēr vēlas uzzināt, kā viss darbojas. Viņam patīk izjaukt rotaļlietas, lai uzzinātu to noslēpumus.";
                break;
            case 2:
                infoText.text = "Toms ir sportisks un aktīvs puika. Viņš spēlē futbolu, brauc ar velosipēdu un palīdz draugiem, kad viņiem nepieciešama palīdzība.";
                break;
        }
    }
}
