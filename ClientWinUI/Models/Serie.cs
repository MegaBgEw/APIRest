using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientWinUI.Models
{
    public class Serie
    {
        private int serieid;
        private string titre;
        private string resume;
        private int nbsaisons;
        private int nbepisodes;
        private int anneecreation;
        private string network;

        public Serie(int serieid, string titre, string resume, int nbsaisons, int nbepisodes, int anneecreation, string network)
        {
            Serieid = serieid;
            Titre = titre;
            Resume = resume;
            Nbsaisons = nbsaisons;
            Nbepisodes = nbepisodes;
            Anneecreation = anneecreation;
            Network = network;
        }

        public int Serieid { get => serieid; set => serieid = value; }
        public string Titre { get => titre; set => titre = value; }
        public string Resume { get => resume; set => resume = value; }
        public int Nbsaisons { get => nbsaisons; set => nbsaisons = value; }
        public int Nbepisodes { get => nbepisodes; set => nbepisodes = value; }
        public int Anneecreation { get => anneecreation; set => anneecreation = value; }
        public string Network { get => network; set => network = value; }

        public override bool Equals(object obj)
        {
            return obj is Serie serie &&
                   Serieid == serie.Serieid &&
                   Titre == serie.Titre &&
                   Resume == serie.Resume &&
                   Nbsaisons == serie.Nbsaisons &&
                   Nbepisodes == serie.Nbepisodes &&
                   Anneecreation == serie.Anneecreation &&
                   Network == serie.Network;
        }
    }
}
