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

        //Omdat er best veel unit tests zijn heb ik via regions de tests per classe file gescheden
        //Als eerste de tests voor de lamp classe
        #region Unit tests lamp
        //Test om te bewijzen dat een lamp kan worden aangemaakt
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
        #endregion

        //Dit is een region voor de sein classe, en de directe afgeleiden hiervan
        #region Unit Tests Seinen

        //Test om te bewijzen dat een sein kan worden aangemaakt en dat een base classe sein geen lampen bevat.
        [Fact]
        public void SeinCreationTest()
        {
            //Arrange
            Sein sein = new Sein(100, 100, 100, 100);
            //Act

            //Assert
            Assert.True(sein.Lamp1 == null && sein.Lamp2 == null);
        }

        //Test om te bewijzen dat de sein teken methode aangeroepen kan worden zonder dat de applicatie breekt
        [Fact]
        public void SeinDrawTest()
        {
            //Arrange
            Control control = new Control();
            Graphics g = control.CreateGraphics();
            Sein sein = new Sein(4, 4, 4, 4);
            //Act
            sein.Teken(g);
            //Assert
        }
        //Test om te bewijzen dat een station sein kan worden aangemaakt en dat een station sein lampen bevat waarvan een groen is.
        [Fact]
        public void StationSeinCreationTest()
        {
            //Arrange
            StationSein sein = new StationSein(100, 100, 100, 100);
            //Act

            //Assert
            Assert.True(LampKleur.Groen == sein.Lamp2.Kleur && LampKleur.Rood == sein.Lamp1.Kleur);
        }

        //Test om te bewijzen dat de sein teken methode aangeroepen kan worden
        [Fact]
        public void StationSeinDrawTest()
        {
            //Arrange
            Control control = new Control();
            Graphics g = control.CreateGraphics();
            StationSein sein = new StationSein(4, 4, 4, 4);
            //Act
            sein.Teken(g);
            //Assert
        }

        //Tests om de werking van de station status te bewijzen
        [Theory]
        [InlineData(1, 0, 1)]
        [InlineData(2, 1, 0)]
        [InlineData(3, 1, 1)]
        [InlineData(4, 0, 0)]
        public void StationStatusTest(int status, int verwachtlinks, int verwachtrechts)
        {
            //arrange
            StationSein sein = new StationSein(100, 100, 100, 100);
            LampStatus verwachtseinStatus = LampStatus.Uit;
            LampStatus verwachtseinStatus2 = LampStatus.Uit;
            //act
            switch (status)
            {
                case 1:
                    sein.Status = StationSeinStatus.Groen;
                    break;
                case 2:
                    sein.Status = StationSeinStatus.Rood;
                    break;
                case 3:
                    sein.Status = StationSeinStatus.Storing;
                    break;
                case 4:
                    sein.Status = StationSeinStatus.Uit;
                    break;
                default:
                    break;
            }
            if (verwachtlinks == 1)
            {
                verwachtseinStatus = LampStatus.Aan;
            }
            if (verwachtrechts == 1)
            {
                verwachtseinStatus2 = LampStatus.Aan;
            }

            //assert
            Assert.True(verwachtseinStatus == sein.Lamp1.Status && verwachtseinStatus2 == sein.Lamp2.Status);
        }

        //Test om te bewijzen dat een station sein kan worden aangemaakt en dat een station sein lampen bevat waarvan een groen is.
        [Fact]
        public void OvergangSeinCreationTest()
        {
            //Arrange
            SpoorwegOvergangSein sein = new SpoorwegOvergangSein(100, 100, 100, 100);
            //Act

            //Assert
            Assert.True(LampKleur.Rood == sein.Lamp2.Kleur && LampKleur.Rood == sein.Lamp1.Kleur);
        }

        //Test om te bewijzen dat de sein teken methode aangeroepen kan worden
        [Fact]
        public void OvergangSeinDrawTest()
        {
            //Arrange
            Control control = new Control();
            Graphics g = control.CreateGraphics();
            SpoorwegOvergangSein sein = new SpoorwegOvergangSein(4, 4, 4, 4);
            //Act
            sein.Teken(g);
            //Assert
        }

        //Tests om de werking van de station status te bewijzen
        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData(2, 0, 1)]
        [InlineData(3, 1, 1)]
        [InlineData(4, 0, 0)]
        public void OvergangStatusTest(int status, int verwachtlinks, int verwachtrechts)
        {
            //arrange
            SpoorwegOvergangSein sein = new SpoorwegOvergangSein(100, 100, 100, 100);
            LampStatus verwachtseinStatus = LampStatus.Uit;
            LampStatus verwachtseinStatus2 = LampStatus.Uit;
            //act
            switch (status)
            {
                case 1:
                    sein.Status = OvergangSeinStatus.Aan;
                    break;
                case 2:
                    sein.Status = OvergangSeinStatus.AanR;
                    break;
                case 3:
                    sein.Status = OvergangSeinStatus.Storing;
                    break;
                case 4:
                    sein.Status = OvergangSeinStatus.Uit;
                    break;
                default:
                    break;
            }
            if (verwachtlinks == 1)
            {
                verwachtseinStatus = LampStatus.Aan;
            }
            if (verwachtrechts == 1)
            {
                verwachtseinStatus2 = LampStatus.Aan;
            }

            //assert
            Assert.True(verwachtseinStatus == sein.Lamp1.Status && verwachtseinStatus2 == sein.Lamp2.Status);


            

        }
        #endregion

        //De region voor alle spoorelementen
        #region Unit Tests Spoorelementen

        //Bewijst dat een rechte rail spoorelement gemaakt kan worden, dat de orientatie verandert kan worden en dat de teken methode werkt
        [Fact]
        public void RailsRechtCreationAndDrawTest()
        {
            //Arrange
            SpoorRailsRecht spoorRailsRecht = new SpoorRailsRecht(1, 1, 1, 1, Orientatie.Verticaal);
            Control control = new Control();
            Graphics g = control.CreateGraphics();
            //Act
            spoorRailsRecht.Teken(g);
            spoorRailsRecht.Orientatie = Orientatie.Horizontaal;
            //Assert
            Assert.True(spoorRailsRecht.Orientatie == Orientatie.Horizontaal);
        }

        //Bewijst dat een rechte rail spoorelement gemaakt kan worden en dat de teken methode werkt
        [Fact]
        public void RailsKromCreationAndDrawTest()
        {
            //Arrange
            SpoorRailsKrom spoorRailsKrom = new SpoorRailsKrom(1, 1, 1, 1, RailRotatie._0);
            Control control = new Control();
            Graphics g = control.CreateGraphics();
            //Act
            spoorRailsKrom.Teken(g);
            //Assert
            
        }
        //Bewijst dat een Trein station aangemaakt kan worden en dat de teken methode aangeroepen kan worden
        [Fact]
        public void StationCreationAndDrawTest()
        {
            //Arrange
            TreinStation treinStation = new TreinStation(1, 1, 1, 1);
            Control control = new Control();
            Graphics g = control.CreateGraphics();
            //Act
            treinStation.Teken(g);
            //Assert
            Assert.True(treinStation.StationSeinStatus == StationSeinStatus.Uit);
        }

        //Bewijst dat een Trein station aangemaakt kan worden en dat de status verandert kan worden
        [Fact]
        public void TreinStationStatusTest()
        {
            //Arrange
            TreinStation treinStation = new TreinStation(1, 1, 1, 1);
            //Act
            treinStation.StationSeinStatus = StationSeinStatus.Groen;
            //Assert
            Assert.True(treinStation.StationSeinStatus == StationSeinStatus.Groen && treinStation.Sein1.Status == StationSeinStatus.Groen && treinStation.Sein2.Status == StationSeinStatus.Rood);
        }

        //Bewijst dat een Spoorweg overgang aangemaakt kan worden en dat de teken methode aangeroepen kan worden
        [Fact]
        public void OvergangCreationAndDrawTest()
        {
            //Arrange
            SpoorwegOvergang overgang = new SpoorwegOvergang(1, 1, 1, 1,Orientatie.Horizontaal);
            Control control = new Control();
            Graphics g = control.CreateGraphics();
            //Act
            overgang.Teken(g);
            //Assert
            Assert.True(overgang.Status == OvergangSeinStatus.Uit);
        }

        //Bewijst dat een Spoorweg overgang aangemaakt kan worden en dat de status verandert kan worden
        [Fact]
        public void OvergangElementStatusTest()
        {
            //Arrange
            SpoorwegOvergang overgang = new SpoorwegOvergang(1, 1, 1, 1, Orientatie.Verticaal);
            //Act
            overgang.Status = OvergangSeinStatus.Aan;
            //Assert
            Assert.True(overgang.Status == OvergangSeinStatus.Aan && overgang.Sein1.Status == OvergangSeinStatus.Aan && overgang.Sein2.Status == OvergangSeinStatus.Aan);
        }



        #endregion

        //Als laatste, de tests voor de overkoepelende spoorbaan en controller zelf
        #region Unit Tests Spoorbaan en Controller

        //Test om te bewijzen dat de spoorbaan gemaakt kan worden, getekend kan worden en dat de overgangen en station lists gevult zijn.
        [Fact]
        public void SpoorbaanCreationTest()
        {
            //Arrange
            Spoorbaan spoorbaan = new Spoorbaan(1, 1, 1, 1);
            Control control = new Control();
            Graphics g = control.CreateGraphics();
            //Act
            spoorbaan.Teken(g);
            //Assert
            Assert.NotEmpty(spoorbaan.Overgangen);
            Assert.NotEmpty(spoorbaan.Stations);
        }

        //Test om te bewijzen dat de Controller gemaakt kan worden en dat de zet storing functie kan worden aangeroepen.
        [Fact]
        public void ControllerCreationTest()
        {
            //Arrange
            Spoorbaan spoorbaan = new Spoorbaan(1, 1, 1, 1);
            Control control = new Control();
            Graphics g = control.CreateGraphics();
            Timer timer = new Timer();
            Timer timer2 = new Timer();
            Controller controller = new Controller(spoorbaan, timer, timer2, g);
            bool test = false;
            //Act
            controller.ZetStoring(test);
            //Assert
        }



        #endregion
    }
}
