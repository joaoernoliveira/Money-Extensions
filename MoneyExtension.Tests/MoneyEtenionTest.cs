namespace MoneyExtension.Tests;

public class MoneyExtensionTest
{
    [Fact]
    public void ShouldConnvertDecimalToInt()
    {
        decimal valor = 297.45M;

        var cents = valor.ToCent();
        
        Assert.Equal(29745,cents);
    }
}