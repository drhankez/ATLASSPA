using System;

namespace ATLASSPA
{
    public class Save_Class
    {
        private Save_Class() { }
        private static readonly Lazy<Save_Class> instance = new Lazy<Save_Class>(() => new Save_Class());
        public static Save_Class Instance { get { return instance.Value; } }
        public int SC_id_employer { get; set; }
        public string SC_NOM_employer { get; set; }
        public string SC_PNOM_employer { get; set; }
        public string SC_DATE_N_employer { get; set; }
        public string SC_LIEU_N_employer { get; set; }
        public string SC_DEMEURANT_employer { get; set; }
        public string SC_ENGAGEMENT_employer { get; set; }
        public string SC_DUREE_employer { get; set; }
        public string SC_ENTREE_employer { get; set; }
        public string SC_SORTIE_employer { get; set; }
        public string SC_CHANTIER_employer { get; set; }
        public string SC_SALAIRE_employer { get; set; }
        public string SC_NMR_ASSU_employer { get; set; }
        public string SC_SITUATION_F_employer { get; set; }
        public string SC_NBR_ENF_employer { get; set; }
        public string SC_NMR_ADH_employer { get; set; }
        public string SC_GR_S_employer { get; set; }
        public string SC_TELEPH_employer { get; set; }
        public string SC_EMAIL__employer { get; set; }
        public string SC_SINF__employer { get; set; }
        public string SC_ETAT_CONTR_employer { get; set; }
        public string SC_CONTRAT_TYPE_employer { get; set; }
        public string SC_DATE_REAL_employer { get; set; }
        public string SC_IMG_employer { get; set; }
        public string SC_GENDER_employer { get; set; }
        //
        public byte[] SC_IMG_employer_byteArray { get; set; }

    }
}
