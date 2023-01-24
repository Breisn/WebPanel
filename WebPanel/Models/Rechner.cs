using System.ComponentModel.DataAnnotations;

namespace WebPanel.Models
{
    public class Rechner
    {
        [Required(ErrorMessage = "Bitte gib einen Gültigen Betrag ein!")]
        public int Betrag { get; set; }

        public int Kuh { get; } = 2800;
        public int Schaf { get; set; } = 650;
        public int Ziege { get; set; } = 500;
        public int kZiege { get; set; } = 50;
        public int[] intspeicher = new int[6];

        public void Rechne()
        {
            int[] erg = new int[6];
            int rest = Betrag;
            erg[5] = Betrag;

            erg[0] = rest / Kuh;
            rest = rest % Kuh;

            erg[1] = rest / Schaf;
            rest = rest % Schaf;

            erg[2] = rest / Ziege;
            rest = rest % Ziege;

            erg[3] = rest / kZiege;
            rest = rest % kZiege;

            erg[4] = rest;
            intspeicher = erg;
        }


    }
}
