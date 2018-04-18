using System;
using System.Linq;
using Xunit;

namespace Spoorbaan
{
    public class UnitTests
    {
        //Tests geschreven in Xunit, werkt bijna als MSTest, behalve dat de Fact en Theory tag bestaat.
        //Zie de Xunit pagina voor meer informatie  https://xunit.github.io/

        //Test om te bewijzen dat een lamp kan worden aangemaakt en worden veranderd
        [Fact]
        public void LampCreationTest()
        {
            //Arrange
            Lamp lamp = new Lamp(4, 4);
            //Act
            lamp.Kleur = LampKleur.Rood;
            lamp.Status = LampStatus.Uit;
            //Assert
            Assert.True(lamp.Kleur == LampKleur.Rood && lamp.Status == LampStatus.Uit);
        }
    }
}
