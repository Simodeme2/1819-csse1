class Price {

    public double Waarde { set; get; }
    public string Valuta {set; get; }

    public Price () {

        this.Waarde = 2582;
        this.Valuta = "EUR";

    }

    public Price(double w) {

        this.Waarde = w;
        this.Valuta = "EUR";

    }

    public Price(double w, string v) {

        this.Waarde = w;
        this.Valuta = v;

    }

    public string ToString() {

        return Waarde + " " + Valuta;

    }
}