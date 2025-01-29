using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4._1Employes_Solution
{
    public class Employe
    {
        private string matricule;
        private string nom;
        private string prenom;
        private DateTime dateNaissance;
        private decimal salaireAnnuel;
        private DateTime dateEntree;

        public string Matricule
        {
            get { return matricule; }
            set
            {
                if (value.Length == 7 && int.TryParse(value, out _))
                    matricule = value;
                else
                    throw new ArgumentException("Le matricule doit être composé de sept chiffres.");
            }
        }

        public string Nom
        {
            get { return nom; }
            set
            {
                nom = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Le nom ne peut pas être vide.");
            }
        }

        public string Prenom
        {
            get => prenom;
            set => prenom = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Le prénom ne peut pas être vide.");
        }

        public DateTime DateNaissance
        {
            get => dateNaissance;
            set
            {
                if (value < DateTime.Now)
                    dateNaissance = value;
                else
                    throw new ArgumentException("La date de naissance doit être dans le passé.");
            }
        }

        public double SalaireAnnuel
        {
            get => (double)salaireAnnuel;
            set
            {
                if (value >= 0)
                    salaireAnnuel = (decimal)Math.Round(value, 2);
                else
                    throw new ArgumentException("Le salaire annuel doit être positif.");
            }
        }

        public DateTime DateEntree
        {
            get => dateEntree;
            set
            {
                if (value <= DateTime.Now)
                    dateEntree = value;
                else
                    throw new ArgumentException("La date d'entrée en fonction doit être dans le passé ou aujourd'hui.");
            }
        }

        public Employe(string matricule, string nom, string prenom, DateTime dateNaissance, double salaireAnnuel, DateTime dateEntree)
        {
            Matricule = matricule;
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
            SalaireAnnuel = salaireAnnuel;
            DateEntree = dateEntree;
        }

        public int Age()
        {
            int age = DateTime.Now.Year - dateNaissance.Year;
            if (DateTime.Now.DayOfYear < dateNaissance.DayOfYear)
            {
                age = age - 1;
            }
            return age;
        }
        public int Anciennete() => DateTime.Now.Year - dateEntree.Year - (DateTime.Now.DayOfYear < dateEntree.DayOfYear ? 1 : 0);

        public bool DroitStationnement() => Age() > 40 || Anciennete() > 20;

        public override string ToString()
        {
            return $"Matricule: {Matricule}\nNom: {Nom}\nPrénom: {Prenom}\nDate de Naissance: {DateNaissance:yyyy-MM-dd}\nSalaire Annuel: {SalaireAnnuel:C}\nDate d'Entrée: {DateEntree:yyyy-MM-dd}\nAge: {Age()} ans\nAncienneté: {Anciennete()} ans\nDroit au Stationnement: {(DroitStationnement() ? "Oui" : "Non")}";
        }
    }
}
