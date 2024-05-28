using Microsoft.VisualBasic;

namespace TestDemo.Tests; 
public class UnitTest1 { 
[Fact] 
public void Fuerza() {
    //arrange
    float masa = 2.5F ;
    float aceleracion = 3.7F;
    float expectedResult = 9.25F;
    //act
    var result = Fisica.Fuerza(masa, aceleracion); 
    //Assert 
Assert.Equal(expectedResult, result) ;
}
[Fact] 
public void Trabajo() {
    //arrange
    float fuerza = 12.3F ;
    float distancia = 5.6F;
    float expectedResult = 68.88F;
    //act
    var result = Fisica.Fuerza(fuerza, distancia); 
    //Assert 
Assert.Equal(expectedResult, result) ;
}
[Fact] 
public void Energiac() {
    //arrange
    float dato = 0.5F;
    float masa = 2.7F ;
    float velocidad = 6.4F;
    float expectedResult = 55.296F;
    //act
    var result = Fisica.EnergiaC(masa, velocidad,dato); 
    //Assert 
Assert.Equal(expectedResult, result) ;
}
}