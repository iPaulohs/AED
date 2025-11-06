// ===============================F076=======================================
// Dados um array de vendedores, cada um representado por um objeto com o nome
// do vendedor e a sua qtd de vendas, encontre e retorne o vendedor que obteve
// o maior valor de venda.
// ==========================================================================


using System.Text.Json;

Vendedor[] vendedores =
[
    new Vendedor("Pedro", 15688.98m),
    new Vendedor("Fabio", 68248.80m),
    new Vendedor("Pedro", 5858.15m),
    new Vendedor("Pedro", 39358.83m),
    new Vendedor("Pedro", 12963.72m),
    new Vendedor("Pedro", 14128.53m),
    new Vendedor("Pedro", 75863.98m),
];

static Vendedor VendedorMaiorValorDevenda(Vendedor[] vendedores)
{
    Vendedor? maiorVendedor = vendedores[0];

    foreach (var v in vendedores)
    {
        if (v.TotalVendas > maiorVendedor.TotalVendas)
        {
            maiorVendedor = v;
        }
    }

    return maiorVendedor;
}

Console.WriteLine(VendedorMaiorValorDevenda(vendedores).ToString());


record Vendedor(string NomeVendedor, decimal TotalVendas)
{
    public override string ToString() => JsonSerializer.Serialize(this);
};