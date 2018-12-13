namespace deel3
{
    class DBConnectie
    {
        public class DBConnectie_singleton {
        // Thread-safe oplossing om slechts één instantie aan te maken.
            private static DBConnectie_singleton _instance = new DBConnectie_singleton ();

            // Private constructor om te voorkomen dat anderen een instantie kunnen aanmaken.
            private DBConnectie_singleton () { }

            // Via een static read-only property kan de instantie benaderd worden.
            public static DBConnectie_singleton Instance {
                get {
                    return _instance;
                }
            }
        }
    }
}