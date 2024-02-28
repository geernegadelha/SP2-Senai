namespace Atividade;

class Pessoa_Fisica : Clientes
{
public string cpf {get; set;}
public string rg {get; set;}
    internal object Valor_imposto { get => valor_imposto; set => valor_imposto = value; }

    private new object valor_imposto;
}