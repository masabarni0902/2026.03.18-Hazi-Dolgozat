using Xunit;

namespace SimpleMathGame.Tests;

public class MiniCalculatorTests
{
    private readonly MiniCalculator _calc = new();

    [Fact]
    public void Dupla_Mikor5_Akkor10()
    {
        int eredmeny = _calc.Dupla(5);
        Assert.Equal(10, eredmeny);
    }

    [Fact]
    public void Negyzet_Mikor7_Akkor49()
    {
        Assert.Equal(49, _calc.Negyzet(7));
    }

    [Theory]
    [InlineData(8, 4)]
    [InlineData(10, 5)]
    [InlineData(0, 0)]
    public void Fele_HelyesEredmeny(int bemenet, int elvart)
    {
        Assert.Equal(elvart, _calc.Fele(bemenet));
    }

    [Fact]
    public void Harmad_Mikor30_Akkor10()
    {
        Assert.Equal(10, _calc.Harmad(30));
    }

    [Fact]
    public void SzorozdTizzel_Mikor42_Akkor420()
    {
        Assert.Equal(420, _calc.SzorozdTizzel(42));
    }

    [Theory]
    [InlineData(250, 2)]
    [InlineData(99, 0)]
    [InlineData(0, 0)]
    public void SzazadraOszdHaNemNulla_Teszt(int bemenet, int elvart)
    {
        Assert.Equal(elvart, _calc.SzazadraOszdHaNemNulla(bemenet));
    }

    [Theory]
    [InlineData(123, 9)]
    [InlineData(7, 49)]
    [InlineData(150, 0)]
    public void UtolsoSzamjegyNegyzet_Helyes(int bemenet, int elvart)
    {
        Assert.Equal(elvart, _calc.UtolsoSzamjegyNegyzet(bemenet));
    }

    [Theory]
    [InlineData(23, 2 * 3)] 
    [InlineData(45, 4 * 5)]     
    [InlineData(10, 1 * 0)]     
    [InlineData(99, 9 * 9)]     
    public void ElsoKetSzamjegySzorzata_HelyesEredmeny(int bemenet, int elvart)
    {
        Assert.Equal(elvart, _calc.ElsoKetSzamjegySzorzata(bemenet));
    }

    [Theory]
    [InlineData(5, 8, 64)]  
    [InlineData(9, 3, 81)]  
    [InlineData(4, 4, 16)]   
    public void NagyobbikKetSzamjegySzorzata_Teszt(int a, int b, int elvart)
    {
        Assert.Equal(elvart, _calc.NagyobbikKetSzamjegySzorzata(a, b));
    }

    [Theory]
    [InlineData(6, 18)]    
    [InlineData(7, 3)]      
    [InlineData(0, 0)]    
    public void SzorozdBeHaParosEgyebkentFele_Teszt(int bemenet, int elvart)
    {
        Assert.Equal(elvart, _calc.SzorozdBeHaParosEgyebkentFele(bemenet));
    }
}