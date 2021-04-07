namespace Chifoumi
{
    public class Choix
    {
        private readonly int valeur;

        /// <summary>
        /// Initialise un choix de Chifoumi
        /// </summary>
        /// <param name="libelleChoix">Libellé du choix</param>
        /// <param name="valeurChoix">Valeur du choix 0:Pierre, 1:Feuille, 2:Ciseaux</param>
        public Choix(string libelleChoix, int valeurChoix)
        {
            Libelle = libelleChoix;
            valeur = valeurChoix;
        }

        /// <summary>
        /// Donne le résultat d'un affrontement avec un autre choix
        /// </summary>
        /// <param name="autre">Autre choix avec lequel comparer le choix courant</param>
        /// <returns> 0: Match nul; 1: Choix courant gagne; 2: Autre choix gagne</returns>
        public int Affronter(Choix autre)
            => (3 + valeur - autre.valeur) % 3;

        /// <summary>
        /// Obtient le libellé du choix
        /// </summary>
        public string Libelle { get; }
    }
}