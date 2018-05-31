using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
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
            
            //Assert
            Assert.True(lamp.Kleur == LampKleur.Rood && lamp.Status == LampStatus.Uit);
        }

        //Test om te bewijzen dat de tekenfunctie aangeroepen kan worden
        //Test bewijst niet dat de teken functie correct tekent

        [Fact]
        public void LampDrawTest()
        {
            //Arrange
            Control control = new Control();
            Graphics g = control.CreateGraphics();
            Lamp lamp = new Lamp(4, 4);
            lamp.Kleur = LampKleur.Groen;
            lamp.Status = LampStatus.Aan;
            //Act
            lamp.Teken(g);
            //Assert
        }

        //Test met de aanname dat de lamp met de correct kleur wordt getekent.
        //Omdat bij InlineData alleen simpele datatypes gebruikt kunnen worden wordt er een int meegegeven die de lampstatus, de lampkleur en de controle kleur aangeven

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(1, 2, 2)]
        [InlineData(2, 1, 3)]
        [InlineData(2, 2, 3)]
        public void LampDrawTheoryTest(int aan, int kleur, int controle)
        {
            //Arrange
            Control control = new Control();
            Graphics g = control.CreateGraphics();
            Lamp lamp = new Lamp(4, 4);

            if (aan == 1)
            {
                lamp.Status = LampStatus.Aan;
            }

            if (kleur == 1)
            {
                lamp.Kleur = LampKleur.Groen;
            }   
            //Act
            lamp.Teken(g);
            //Assert
            switch (controle)
            {
                case 1:
                    Assert.Equal(lamp.Sb.Color, Color.Green);
                    break;
                case 2:
                    Assert.Equal(lamp.Sb.Color, Color.Red);
                    break;
                case 3:
                    Assert.Equal(lamp.Sb.Color, Color.DarkGray);
                    break;
            }
        }
    }
}
