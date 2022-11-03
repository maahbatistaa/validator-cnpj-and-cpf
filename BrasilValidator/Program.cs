using BrasilValidator;

var testes = new Teste[] {
    new Teste(null,false),
    new Teste(string.Empty,false),
    new Teste("           ",false),
    new Teste("123 45678901",false),
    new Teste("1234567890",false),
    new Teste("123456789012",false),
    new Teste("00000000000",false),
    new Teste("11111111111",false),
    new Teste("22222222222",false),
    new Teste("33333333333",false),
    new Teste("44444444444",false),
    new Teste("55555555555",false),
    new Teste("66666666666",false),
    new Teste("77777777777",false),
    new Teste("88888888888",false),
    new Teste("99999999999",false),
    new Teste("12433468090",false),
    new Teste("124334680-94",true),
    new Teste("12433468094",true),
    new Teste("12433468094 ",true),
    new Teste(" 12433468094",true),
    new Teste("124 334 680 94",true),
    new Teste("124.334.680-94",true),
    new Teste("449.695.000-61",true),
    new Teste("888.668.281-65",true),
};

var testes2 = new Teste[]{
    new Teste(null,false),
    new Teste(string.Empty,false),
    new Teste("           ",false),
    new Teste("123 45678901234",false),
    new Teste("12345678901234",false),
    new Teste("00000000000000",false),
    new Teste("11111111111111",false),
    new Teste("22222222222222",false),
    new Teste("33333333333333",false),
    new Teste("44444444444444",false),
    new Teste("55555555555555",false),
    new Teste("66666666666666",false),
    new Teste("77777777777777",false),
    new Teste("88888888888888",false),
    new Teste("999999999999999",false),
    new Teste("76 268 126/0001-03",true),
    new Teste("76.268.126/0001-03",true),
    new Teste("76 268 126 0001 03",true),
    new Teste("762681260001-03",true),
    new Teste(" 76268126000103",true),
    new Teste("76268126000103 ",true),
    new Teste("76268126000103",true),
    new Teste("98.750.901/0001-03",true),
    new Teste("25.437.016/000197",true),
    new Teste("53.662.955/0001-70",true),
    new Teste("00.000.000/0001-91",true),
};

Console.WriteLine("Testando CPF:");

foreach (var teste in testes)
{
    Console.Write($"  {teste.TextoATestar,-16} : ");

    try
    {
        var resultado = BrasilValidator.BrasilValidator5.EhCpfValido(teste.TextoATestar);
        var passorfail = resultado == teste.ResultadoEsperado ? "PASS" : "FAIL";
        Console.WriteLine($"{resultado,-6} : {passorfail}");
    }
    catch
    {
        Console.WriteLine($"[erro] : FAIL");
    }
}

Console.WriteLine("\n\nTestando CNPJ:");

foreach (var teste in testes2)
{
    Console.Write($"  {teste.TextoATestar,-16} : ");

    try
    {
        var resultado = BrasilValidator.BrasilValidator5.EhCnpjValido(teste.TextoATestar);
        var passorfail = resultado == teste.ResultadoEsperado ? "PASS" : "FAIL";
        Console.WriteLine($"{resultado,-6} : {passorfail}");
    }
    catch
    {
        Console.WriteLine($"[erro] : FAIL");
    }
}


internal class Teste
{
    public Teste(string? textoATestar, bool resultadoEsperado)
    {
        TextoATestar = textoATestar;
        ResultadoEsperado = resultadoEsperado;
    }

    public string? TextoATestar { get; set; }
    public bool ResultadoEsperado { get; set; }
}