namespace T {

    public class DTPrime : IPrime {

        public IPgmPrime IPgmPrime { get { return new DT.PgmPrime(); } }
    } 
}