using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesComunesBC
{
    public class ConsultesBBDD
    {
        #region Query

        public string queryIpSpaceShip = "SELECT IPSpaceShip FROM SpaceShips WHERE idSpaceShip = 1;";
        public string queryIpPlanet = "SELECT IPPlanet FROM Planets WHERE idPlanet = 2;";

        public string queryPortPlanetFiles = "SELECT PortPlanetFiles FROM Planets WHERE idPlanet = 2;";
        public string queryPortSpaceShipFiles = "SELECT PortSpaceShipFiles FROM SpaceShips WHERE idSpaceShip = 1;";

        public string queryPortPlanetMessage = "SELECT PortPlanetMessage FROM Planets WHERE idPlanet = 2;";
        public string queryPortSpaceShipMessage = "SELECT PortSpaceShipMessage FROM SpaceShips WHERE idSpaceShip = 1;";

        public string queryPortUDPPlanet = "SELECT PortUDPPlanet FROM Planets WHERE idPlanet = 2;";
        public string queryPortUDPSpaceShip = "SELECT PortUDPSpaceShip FROM SpaceShips WHERE idSpaceShip = 1;";

        public string queryTypeSpaceShip = "SELECT TypeSpaceShip FROM SpaceShips WHERE idSpaceShip = 1;";
        public string queryToObtainPublicKey = "SELECT TOP 1 XMLKey FROM PlanetKeys ORDER BY idKey DESC;";

        #endregion
    }
}
