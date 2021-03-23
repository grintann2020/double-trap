namespace T {

    public class RobotPrime : IPrime {

        public IPgmPrime IPgmPrime { get { return new Robot.PgmPrime(); } }
    } 
}