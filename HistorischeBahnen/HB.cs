namespace HistorischeBahnen
{
    class HB
    {
  /*      private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
  */
        public int ID { get; set; }
        public string? ZugName { get; set; }
        public DateTime? ProduktionsDatum { get; set; }
        public int? GewichtInKG { get; set; }
        public string? ZugBeschreibung { get; set; }
        public DateTime? Geandert { get; set; }
        public DateTime? Erstellt { get; set; }

        public HB() { }
        public HB(int iD, string zugName, DateTime produktionsDatum, int gewichtInKG, string zugBeschreibung) {
            ID = iD;
            ZugName = zugName;
            ProduktionsDatum = produktionsDatum;
            GewichtInKG = gewichtInKG;
            ZugBeschreibung = zugBeschreibung;
            Geandert = DateTime.Now;
            Erstellt = DateTime.Now;
        }
        public HB(int iD, string zugName, DateTime produktionsDatum, int gewichtInKG, string zugBeschreibung, DateTime geandert, DateTime erstellt) {
            ID = iD;
            ZugName = zugName;
            ProduktionsDatum = produktionsDatum;
            GewichtInKG = gewichtInKG;
            ZugBeschreibung = zugBeschreibung;
            Geandert= geandert;
            Erstellt = erstellt;
                }
    }
}